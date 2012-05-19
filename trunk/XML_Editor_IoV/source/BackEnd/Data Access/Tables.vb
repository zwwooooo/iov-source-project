Public Class Tables
    Public Const Sounds As String = "SOUND"
    Public Const BurstSounds As String = "BURSTSOUND"

    Public Class Items
        Public Const Name As String = "ITEM"
        Public Class Fields
            Public Const ID As String = "uiIndex"
            Public Const ShortName As String = "szItemName"
            Public Const Name As String = "szLongItemName"
            Public Const Description As String = "szItemDesc"
            Public Const FKey As String = "ubClassIndex"
            Public Const ItemClass As String = "usItemClass"
            Public Const RocketLauncher As String = "rocketlauncher"
            Public Const Attachment As String = "Attachment"
            Public Const SciFi As String = "SciFi"
            Public Const TonsOfGuns As String = "BigGunList"
            Public Const ItemImage As String = "ItemImage"
            Public Const GraphicType As String = "ubGraphicType"
            Public Const GraphicIndex As String = "ubGraphicNum"
        End Class
    End Class
    Public Class Weapons
        Public Const Name As String = "WEAPON"
        Public Class Fields
            Public Const ID As String = "uiIndex"
            Public Const Name As String = "szWeaponName"
            Public Const Caliber As String = "ubCalibre"
            Public Const MagSize As String = "ubMagSize"
        End Class
    End Class

    Public Const Merges As String = "MERGE"
    Public Class Magazines
        Public Const Name As String = "MAGAZINE"
        Public Class Fields
            Public Const ID As String = "uiIndex"
            Public Const Caliber As String = "ubCalibre"
            Public Const MagSize As String = "ubMagSize"
            Public Const AmmoType As String = "ubAmmoType"
        End Class
    End Class
    Public Class Launchables
        Public Const Name As String = "LAUNCHABLE"
        Public Class Fields
            Public Const ItemID As String = "itemIndex"
            Public Const LaunchableID As String = "launchableIndex"
        End Class
    End Class
    Public Const AmmoTypes As String = "AMMOTYPE"
    Public Const AmmoStrings As String = "AMMO"
    Public Class Attachments
        Public Const Name As String = "ATTACHMENT"
        Public Class Fields
            Public Const ItemID As String = "itemIndex"
            Public Const AttachmentID As String = "attachmentIndex"
        End Class
    End Class

    Public Class AttachmentInfo
        Public Const Name As String = "ATTACHMENTINFO"
        Public Class Fields
            Public Const ItemID As String = "usItem"
        End Class
    End Class
    Public Const AttachmentComboMerges As String = "ATTACHMENTCOMBOMERGE"
    Public Const Armours As String = "ARMOUR"
    Public Class CompatibleFaceItems
        Public Const Name As String = "COMPATIBLEFACEITEM"
        Public Class Fields
            Public Const ItemID As String = "itemIndex"
            Public Const CompatibleItemID As String = "compatiblefaceitemIndex"
        End Class
    End Class
    Public Class IncompatibleAttachments
        Public Const Name As String = "INCOMPATIBLEATTACHMENT"
        Public Class Fields
            Public Const ItemID As String = "itemIndex"
            Public Const IncompatibleItemID As String = "incompatibleattachmentIndex"
        End Class
    End Class
    Public Const ExplosionData As String = "EXPDATA"
    Public Const Explosives As String = "EXPLOSIVE"
    Public Const MergeTypes As String = "MergeType"
    Public Const ExplosionTypes As String = "ExplosionType"
    Public Const ItemClasses As String = "ItemClass"
    Public Const SkillCheckTypes As String = "SkillCheckType"
    Public Const ArmourClasses As String = "ArmourClass"
    Public Const WeaponTypes As String = "WeaponType"
    Public Const WeaponClasses As String = "WeaponClass"
    Public Const AttachmentClasses As String = "AttachmentClass"
    Public Const AttachmentSystem As String = "AttachmentSystem"
    Public Const Cursors As String = "Cursor"
    Public Const GermanItems As String = "GermanItem"
    Public Const RussianItems As String = "RussianItem"
    Public Const PolishItems As String = "PolishItem"
    Public Const FrenchItems As String = "FrenchItem"
    Public Const ItalianItems As String = "ItalianItem"
    Public Const DutchItems As String = "DutchItem"
    Public Const ChineseItems As String = "ChineseItem"
    Public Const GermanAmmoStrings As String = "GermanAmmo"
    Public Const RussianAmmoStrings As String = "RussianAmmo"
    Public Const PolishAmmoStrings As String = "PolishAmmo"
    Public Const FrenchAmmoStrings As String = "FrenchAmmo"
    Public Const ItalianAmmoStrings As String = "ItalianAmmo"
    Public Const DutchAmmoStrings As String = "DutchAmmo"
    Public Const ChineseAmmoStrings As String = "ChineseAmmo"

    Public Class LookupTableFields
        Public Const Name As String = "name"
        Public Const ID As String = "id"
    End Class

    Public Const AlbertoInventory As String = "AlbertoInventory"
    Public Const ArnieInventory As String = "ArnieInventory"
    Public Const CarloInventory As String = "CarloInventory"
    Public Const DevinInventory As String = "DevinInventory"
    Public Const ElginInventory As String = "ElginInventory"
    Public Const FrankInventory As String = "FrankInventory"
    Public Const FranzInventory As String = "FranzInventory"
    Public Const FredoInventory As String = "FredoInventory"
    Public Const GabbyInventory As String = "GabbyInventory"
    Public Const HerveInventory As String = "HerveInventory"
    Public Const HowardInventory As String = "HowardInventory"
    Public Const JakeInventory As String = "JakeInventory"
    Public Const KeithInventory As String = "KeithInventory"
    Public Const MannyInventory As String = "MannyInventory"
    Public Const MickeyInventory As String = "MickeyInventory"
    Public Const PerkoInventory As String = "PerkoInventory"
    Public Const PeterInventory As String = "PeterInventory"
    Public Const SamInventory As String = "SamInventory"
    Public Const TonyInventory As String = "TonyInventory"
    Public Const Inventory As String = "Inventory"
    Public Const AlbertoControl As String = "AlbertoControl"
    Public Const ArnieControl As String = "ArnieControl"
    Public Const CarloControl As String = "CarloControl"
    Public Const DevinControl As String = "DevinControl"
    Public Const ElginControl As String = "ElginControl"
    Public Const FrankControl As String = "FrankControl"
    Public Const FranzControl As String = "FranzControl"
    Public Const FredoControl As String = "FredoControl"
    Public Const GabbyControl As String = "GabbyControl"
    Public Const HerveControl As String = "HerveControl"
    Public Const HowardControl As String = "HowardControl"
    Public Const JakeControl As String = "JakeControl"
    Public Const KeithControl As String = "KeithControl"
    Public Const MannyControl As String = "MannyControl"
    Public Const MickeyControl As String = "MickeyControl"
    Public Const PerkoControl As String = "PerkoControl"
    Public Const PeterControl As String = "PeterControl"
    Public Const SamControl As String = "SamControl"
    Public Const TonyControl As String = "TonyControl"
    Public Const Control As String = "Control"
    Public Const IMPItems As String = "IMPITEMCHOICES"
    Public Const EnemyGuns As String = "ENEMYGUNCHOICES"
    Public Const EnemyItems As String = "ENEMYITEMCHOICES"
    Public Const EnemyAmmo As String = "ENEMYAMMOCHOICES"
    Public Const EnemyAmmoDrops As String = "EnemyAmmoDrops"
    Public Const EnemyArmourDrops As String = "EnemyArmourDrops"
    Public Const EnemyExplosiveDrops As String = "EnemyExplosiveDrops"
    Public Const EnemyMiscDrops As String = "EnemyMiscDrops"
    Public Const EnemyWeaponDrops As String = "EnemyWeaponDrops"

    Public Class InventoryTableFields
        Public Const ID As String = "uiIndex"
        Public Const ItemID As String = "sItemIndex"
        Public Const Quantity As String = "ubOptimalNumber"
    End Class

    Public Const Pockets As String = "POCKET"
    Public Const LoadBearingEquipment As String = "LOADBEARINGEQUIPMENT"
    Public Const LBEClasses As String = "LBEClass"
    Public Const Silhouettes As String = "Silhouette"
    Public Class MercStartingGear
        Public Const Name As String = "MERCGEAR"
        Public Class Fields
            Public Const ID As String = "mIndex"
            Public Const Name As String = "mName"
        End Class
    End Class
    Public Const AttachmentSlots As String = "ATTACHMENTSLOT"

End Class