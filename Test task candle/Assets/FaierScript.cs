using UnityEngine;

public class FaierScript : MonoBehaviour
{
    [SerializeField] GameObject _hand;
    [SerializeField] GameObject _faier;
    [SerializeField] bool _save;
    private float _taimer;

    private void Start()
    {
        _taimer = 0;
    }
    private void Update()
    {
        Hand();
    }
    private void Hand()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        { 
            _save = true;
            _hand.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E)) 
        { 
            _save = false;
            _hand.SetActive(false);
        }        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("rain")&&!_save)
        {           
            _faier.SetActive(false);           
        }
        if (other.CompareTag("wind") && !_save)
        {
            _taimer += Time.deltaTime;
            if (_taimer > 4)
            {
                _faier.SetActive(false);
            }
        }
    }    
}
