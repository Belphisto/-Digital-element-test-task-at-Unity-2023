using UnityEngine;

public class MultimeterController 
{
    public MultimeterView _multimeterView;
    public MultimeterModel _multimeterModel;
    public ToggleSwithHighlight _toggle;

    public MultimeterController(MultimeterView view, MultimeterModel model, ToggleSwithHighlight toggle)
    {
        _multimeterView = view;
        _multimeterModel = model;
        _toggle = toggle;
        _multimeterView.OnAngleChanged += HandleAngleChanged;
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(_toggle.getToggle()));
        _toggle.OnToggleChanged += HandleToggleChanged;
    }

    private void HandleAngleChanged(float angle)
    {
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(_toggle.getToggle()));
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(_toggle.getToggle()), _toggle.getToggle());
    }

    private void HandleToggleChanged(float toggle)
    {
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(_toggle.getToggle()));
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(toggle), _toggle.getToggle());
    }

    void Update()
    {
        _multimeterView.OnAngleChanged += HandleAngleChanged;
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(_toggle.getToggle()));
        _multimeterView.UpdateValue(_multimeterModel.CalculateCurrent(_toggle.getToggle()), _toggle.getToggle());
       
    }
}
