using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class DataWindow : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset;

    private AnimParam m_AnimParam;
    private AnimParam m_LastKnownState;

    [MenuItem("Window/UI Toolkit/DataWindow")]
    public static void ShowExample()
    {
        DataWindow wnd = GetWindow<DataWindow>();
        wnd.titleContent = new GUIContent("DataWindow");
    }

    private void OnEnable()
    {
        LoadAnimParam();
        CreateGUI();
        EditorApplication.update += UpdateEditor;
    }

    private void OnDisable()
    {
        EditorApplication.update -= UpdateEditor;
    }

    private void LoadAnimParam()
    {
        // Load the AnimParam asset named "Data" from the correct path
        m_AnimParam = AssetDatabase.LoadAssetAtPath<AnimParam>("Assets/Scripts/Data.asset");

        if (m_AnimParam == null)
        {
            Debug.LogError("Failed to load AnimParam ScriptableObject. Make sure the asset exists at 'Assets/Scripts/Data.asset'.");
        }
        else
        {
            // Save the initial state of the ScriptableObject
            m_LastKnownState = Instantiate(m_AnimParam);
        }
    }

    private void CreateGUI()
    {
        if (m_AnimParam == null)
        {
            Debug.LogError("AnimParam ScriptableObject is not assigned.");
            return;
        }

        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Clear previous elements
        root.Clear();

        // Instantiate UXML
        VisualElement uiFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(uiFromUXML);

        // Add change listeners for each float field
        AddChangeListeners(uiFromUXML);
    }

    private void AddChangeListeners(VisualElement rootElement)
    {
        // Get all the float fields in the UXML and add change listeners
        foreach (var fieldInfo in typeof(AnimParam).GetFields())
        {
            if (fieldInfo.FieldType == typeof(float))
            {
                string fieldName = fieldInfo.Name;
                FloatField floatField = rootElement.Q<FloatField>(fieldName);

                if (floatField != null)
                {
                    // Set initial value
                    floatField.SetValueWithoutNotify((float)fieldInfo.GetValue(m_AnimParam));

                    // Register value change callback
                    floatField.RegisterValueChangedCallback(evt =>
                    {
                        fieldInfo.SetValue(m_AnimParam, evt.newValue);
                    });
                }
                else
                {
                    Debug.LogWarning($"FloatField with name {fieldName} not found in UXML.");
                }
            }
        }
    }

    private void UpdateEditor()
    {
        if (m_AnimParam == null || m_LastKnownState == null)
        {
            return;
        }

        // Check if the ScriptableObject has been modified
        if (!CompareAnimParams(m_AnimParam, m_LastKnownState))
        {
            // If it has been modified, update the UI
            CreateGUI();
            // Update the last known state
            m_LastKnownState = Instantiate(m_AnimParam);
        }
    }

    private bool CompareAnimParams(AnimParam a, AnimParam b)
    {
        // Compare each field of the ScriptableObjects
        var fields = typeof(AnimParam).GetFields();
        foreach (var field in fields)
        {
            if (!field.GetValue(a).Equals(field.GetValue(b)))
            {
                return false;
            }
        }
        return true;
    }
}