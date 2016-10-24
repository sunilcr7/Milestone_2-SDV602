using UnityEngine;
using System.Collections;
using SQLite4Unity3d;

public class Account
{

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Petrol { get; set; }
    public int Money { get; set; }
    public string Scene { get; set; }
    public int CarsCollected { get; set; }

    public string Password { get; set; }



    public override string ToString()
    {
        return string.Format("[Person: Id: {0}, Name: {1},  Petrol: {2}, Money: {3}, Scene: {4}, Cars Collected: {5}, Passord: {6}]", Id, Name, Petrol, Money, Scene, CarsCollected, Password);
    }
}