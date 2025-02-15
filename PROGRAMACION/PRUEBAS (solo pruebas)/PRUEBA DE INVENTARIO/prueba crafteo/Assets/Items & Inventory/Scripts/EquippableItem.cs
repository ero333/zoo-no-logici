﻿using UnityEngine;

public enum EquipmentType
{
   Animal,
   Animal2,
   Animal3,
}

[CreateAssetMenu]
public class EquippableItem : Item //ESTO SIRVE PARA DECLARAR CUALES SON LOS ITEMS QUE PUEDEN SER LLEVADOS AL MENU DEL JUGADOR Y QUE PUEDEN SER EQUIPABLES
                                     //ESE MENU DE EQUIPABLES EN REALIDAD SERÍA EL MENU DE CRUZA, Y LOS UNICOS ITEMS QUE PODRIAN SER LLEVADOS ALLI SERIAN LOS ANIMALES
                                     //MUCHOS INT DE ACA SON DEL EJEMPLO DEL TUTORIAL, YO DEJO EL DE PELIGROSIDAD PORQUE LO USARIAMOS PARA ASIGNARLE UN NUMERO FIJO Y DESPUES CALCULAR
                                     //UN PORCENTAJE AL MOMENTO DE CRUZAR
{
    public int StrengthBonus;
    public int Peligrosidad;
    public int Hambre;
    public int Vitalidad;
    [Space] // Esto simplemente crea un espacio en el inspector de unity, es para separar los valores en si de los valores en porcentaje
    public float StrengthPercentBonus;
    public float PeligrosidadPercent;
    public float HambrePercent;
    public float VitalidadPercent;
    [Space]
    public EquipmentType EquipmentType;



    public void Unequip(Character c)
    {
        Debug.Log("PIJA");
    }

    public void Equip(Character c)
    {
        Debug.Log("culo");
    }
}
