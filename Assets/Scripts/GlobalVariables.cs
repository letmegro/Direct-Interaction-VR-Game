/*
 * Nicolas Korsunski
 * 2022-10-08
 * 
 * This is the global variable and control script used to manage variables and scripts which require global communication
 */
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

    private static bool secretKey;
    private static bool apartmentKey;
    private static bool secretDoc;
    private static bool weaponAtHand;
    private static bool checkPointATriggered;
    private static bool isPaperNotWatched;
    private static bool isPaperReachedFor;
    private static string inputPuzzle = "";
    private static int playerHealth = 3;
    private static bool isAIWeaponReady;
    private static bool isDistracted;
    private static bool exit;
    private static bool snapTurn;
    private static bool continousTurn;
    private static bool headOfficeEntered;
    private static bool isKingDistracted;
    private static bool allEnemiesAttack;
    private static int optionCycle;
    private static bool spaceKeyPressed;
    private static bool medicineGiven;

    public static void Reset()
    {
        PlayerHealth = 3;
        InputPuzzle = "";
        IsPaperNotWatched = false;
        WeaponAtHand = false;
        CheckPointATriggered = false;
        SecretDoc = false;
        SecretKey = false;
        ApartmentKey = false;
        IsPaperReachedFor = false;
        IsDistracted = false;
        Exit = false;
        IsKingDistracted = false;
        HeadOfficeEntered = false;
        AllEnemiesAttack = false;
        OptionCycle = 0;
        SpaceKeyPressed = false;
        MedicineGiven = false;
    }

    //getters and setters for the private variables

    //max ammo has a default of 15
    public static int MaxAmmo
    {
        get => 15;
    }

    public static int PlayerHealth
    {
        get => playerHealth; set => playerHealth = value;
    }

    public static int OptionCycle
    {
        get => optionCycle; set => optionCycle = value;
    }

    public static string InputPuzzle
    {
        get => inputPuzzle; set => inputPuzzle = value;
    }

    public static bool MedicineGiven
    {
        get => medicineGiven; set => medicineGiven = value;
    }

    public static bool SpaceKeyPressed
    {
        get => spaceKeyPressed; set => spaceKeyPressed = value;
    }

    public static bool Exit
    {
        get => exit; set => exit = value;
    }

    public static bool SnapTurn
    {
        get => snapTurn; set => snapTurn = value;
    }

    public static bool ContinousTurn
    {
        get => continousTurn; set => continousTurn = value;
    }

    public static bool HeadOfficeEntered
    {
        get => headOfficeEntered; set => headOfficeEntered = value;
    }

    public static bool IsKingDistracted
    {
        get => isKingDistracted; set => isKingDistracted = value;
    }

    public static bool IsAIWeaponReady
    {
        get => isAIWeaponReady; set => isAIWeaponReady = value;
    }

    public static bool IsPaperReachedFor
    {
        get => isPaperReachedFor; set => isPaperReachedFor = value;
    }

    public static bool AllEnemiesAttack
    {
        get => allEnemiesAttack; set => allEnemiesAttack = value;
    }

    public static bool IsDistracted
    {
        get => isDistracted; set => isDistracted = value;
    }

    public static bool IsPaperNotWatched
    {
        get => isPaperNotWatched; set => isPaperNotWatched = value;
    }

    public static bool WeaponAtHand
    {
        get => weaponAtHand; set => weaponAtHand = value;
    }

    public static bool CheckPointATriggered
    {
        get => checkPointATriggered; set => checkPointATriggered = value;
    }

    public static bool SecretKey
    {
        get => secretKey; set => secretKey = value;
    }
    public static bool ApartmentKey
    {
        get => apartmentKey; set => apartmentKey = value;
    }

    public static bool SecretDoc
    {
        get => secretDoc; set => secretDoc = value;
    }

}
