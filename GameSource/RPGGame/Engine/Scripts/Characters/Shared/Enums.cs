namespace RPG.Engine.Scripts.Characters.Shared
{
    /// <summary>
    /// Enumeration for the direction of the characters
    /// </summary>
    public enum Direction
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
        Still = 5
    }

    /// <summary>
    /// Enumeration for the rarity of the items
    /// </summary>
    public enum ItemRarity
    {
        Poor = 0,
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epic = 4,
        Legendary = 5
    }

    public enum ItemSlot
    {
        Hat = 0,
        ChestArmour = 1,
        Pants = 2,
        Boots = 3,
        OneHand = 4,
        TwoHand = 5,
        OffHand = 6,
        Ring = 7,
        Amulet = 8,
        Shoulders = 9,
        Gloves = 10,
        Bracers = 11,
        Belt = 12,
        NoSlot = 13
    }

    public enum SkillType
    {
        Base,
        Area,
        Ultimate
    }

    public enum SkillRange
    {
        Melee,
        Range
    }
}
