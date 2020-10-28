using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo_Efeitos : MonoBehaviour
{
    public static int n_pecas_frank , n_pecas_gato ,n_pecas_tauro;
    public int pecas_frank, pecas_gato , pecas_tauro;

    private void Update()
    {
        pecas_tauro = n_pecas_tauro;
        pecas_frank = n_pecas_frank;
        pecas_gato = n_pecas_gato;
    }
}
