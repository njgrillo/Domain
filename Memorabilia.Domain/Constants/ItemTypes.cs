namespace Memorabilia.Domain.Constants;

public sealed class ItemTypes : DomainItemConstants
{
    public static readonly ItemTypes Bammer = new(32, "Bammer");
    public static readonly ItemTypes Baseball = new(1, "Baseball");
    public static readonly ItemTypes Basketball = new(2, "Basketball", true);
    public static readonly ItemTypes Bat = new(3, "Bat", true);
    public static readonly ItemTypes Bobble = new(34, "Bobblehead");
    public static readonly ItemTypes Book = new(4, "Book");       
    public static readonly ItemTypes Bookplate = new(26, "Bookplate");       
    public static readonly ItemTypes Canvas = new(6, "Canvas", true);
    public static readonly ItemTypes CerealBox = new(35, "Cereal Box");
    public static readonly ItemTypes CompactDisc = new(28, "CD");
    public static readonly ItemTypes Document = new(36, "Document", true);
    public static readonly ItemTypes Drum = new(30, "Drum");        
    public static readonly ItemTypes Figure = new(8, "Figure");
    public static readonly ItemTypes FirstDayCover = new(5, "First Day Cover");
    public static readonly ItemTypes Football = new(9, "Football", true);
    public static readonly ItemTypes Glove = new(10, "Glove");
    public static readonly ItemTypes Golfball = new(42, "Golf Ball");       
    public static readonly ItemTypes Guitar = new(29, "Guitar");
    public static readonly ItemTypes Hat = new(23, "Hat");
    public static readonly ItemTypes HeadBand = new(41, "Head Band");
    public static readonly ItemTypes Helmet = new(11, "Helmet", true);
    public static readonly ItemTypes HockeyStick = new(21, "Hockey Stick");
    public static readonly ItemTypes IndexCard = new(27, "Index Card");
    public static readonly ItemTypes Jersey = new(12, "Jersey", true);
    public static readonly ItemTypes JerseyNumber = new(13, "Jersey Number");
    public static readonly ItemTypes Lithograph = new(24, "Lithograph", true);
    public static readonly ItemTypes Magazine = new(14, "Magazine");
    public static readonly ItemTypes Other = new(15, "Other");
    public static readonly ItemTypes Painting = new(16, "Painting", true);
    public static readonly ItemTypes Pants = new(39, "Pants");
    public static readonly ItemTypes Photo = new(17, "Photo", true);
    public static readonly ItemTypes PinFlag = new(43, "Pin Flag");
    public static readonly ItemTypes PlayingCard = new(31, "Playing Card");
    public static readonly ItemTypes Poster = new(33, "Poster", true);
    public static readonly ItemTypes Puck = new(18, "Puck");        
    public static readonly ItemTypes Pylon = new(19, "Pylon");
    public static readonly ItemTypes Shirt = new(37, "Shirt");
    public static readonly ItemTypes Shoe = new(25, "Shoe");   
    public static readonly ItemTypes Soccerball = new(20, "Soccer Ball");
    public static readonly ItemTypes Tennisball = new(44, "Tennis Ball");
    public static readonly ItemTypes TennisRacket = new(45, "Tennis Racket");
    public static readonly ItemTypes Ticket = new(22, "Ticket");
    public static readonly ItemTypes TradingCard = new(7, "Trading Card");
    public static readonly ItemTypes Trunks = new(38, "Trunks");
    public static readonly ItemTypes WristBand = new(40, "Wrist Band");

    public bool DisplaySizeInTitles { get; set; } 

    public static readonly ItemTypes[] All =
    [
        Bammer,
        Baseball,
        Basketball,
        Bat,
        Bobble,
        Book,
        Bookplate,
        Canvas,
        CerealBox,
        CompactDisc,
        Document,
        Drum,
        Figure,
        FirstDayCover,
        Football,
        Glove,
        Golfball,
        Guitar,
        Hat,
        HeadBand,
        Helmet,
        HockeyStick,
        IndexCard,
        Jersey,
        JerseyNumber,
        Lithograph,
        Magazine,
        Other,
        Painting,
        Pants,
        Photo,
        PinFlag,
        PlayingCard,
        Poster,
        Puck,
        Pylon,
        Shirt,
        Shoe,
        Soccerball,
        Tennisball,
        TennisRacket,
        Ticket,
        TradingCard,
        Trunks,
        WristBand
    ];

    public static readonly ItemTypes[] GameTypes =
    [
        Baseball,
        Basketball,
        Bat,
        Football,
        Glove,
        Golfball,
        Hat,
        HeadBand,
        Helmet,
        HockeyStick,
        Jersey,
        Pants,
        PinFlag,
        Puck,
        Pylon,
        Shirt,
        Shoe,
        Soccerball,
        Tennisball,
        TennisRacket,
        Trunks,
        WristBand
    ];

    public static readonly ItemTypes[] SizeTypes =
    [
        Bammer,
        Baseball,
        Basketball,
        Bat,
        Bobble,
        Canvas,
        Document,
        Football,
        Hat,
        HeadBand,
        Helmet,
        HockeyStick,
        IndexCard,
        Jersey,
        Lithograph,
        Magazine,
        Painting,
        Pants,
        Photo,
        Poster,
        Shirt,
        Shoe,
        Ticket,
        TradingCard,
        Trunks
    ];

    public static readonly ItemTypes[] SpotTypes =
    [
        Bammer,
        Baseball,
        Bobble,
        Book,
        CompactDisc,
        Figure,
        Glove,
        Hat,
        Helmet,
        HockeyStick,
        Jersey,
        Magazine,
        PlayingCard,
        Shirt,
        Shoe,
        Tennisball,
        Ticket,
        TradingCard,
        Trunks
    ];

    public static readonly ItemTypes[] TeamTypes =
    [
        Bammer,
        Baseball,
        Basketball,
        Bobble,
        Book,
        Canvas,
        CerealBox,
        Document,
        Figure,
        FirstDayCover,
        Football,
        Hat,
        HeadBand,
        Helmet,
        HockeyStick,
        Jersey,
        Lithograph,
        Magazine,
        Painting,
        Pants,
        Photo,
        Poster,
        Puck,
        Pylon,
        Shirt,
        Soccerball,
        Ticket,
        TradingCard,
        WristBand
    ];

    public static readonly ItemTypes[] WearableTypes =
    [
        Glove,
        Hat,
        HeadBand,
        Helmet,
        Jersey,
        Pants,
        Shirt,
        Shoe,
        Trunks,
        WristBand
    ];

    private ItemTypes(int id, string name, bool displaySizeInTitles = false) 
        : base(id, name) 
    { 
        DisplaySizeInTitles = displaySizeInTitles;
    }

    public static ItemTypes Find(int id)
        => All.SingleOrDefault(ItemTypes => ItemTypes.Id == id);

    public static ItemTypes Find(string name)
        => All.SingleOrDefault(ItemTypes => ItemTypes.Name == name);
}
