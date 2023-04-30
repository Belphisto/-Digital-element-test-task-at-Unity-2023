using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _multimeterPrefab;
    private MultimeterController _multimeterController;
    private MultimeterModel _multimeterModel;
    public ToggleSwithHighlight _toggle;
    public MultimeterView _view;

    // Start is called before the first frame update
    void Start()
    {
        _multimeterModel = new MultimeterModel();
        var multimeterObject = Instantiate(_multimeterPrefab, Vector3.zero, Quaternion.identity);
        //var multimeterView = multimeterObject.GetComponent<MultimeterView>();
        //_toggle= multimeterObject.GetComponent<ToggleSwithHighlight>();

        _multimeterController = new MultimeterController(_view, _multimeterModel, _toggle);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
