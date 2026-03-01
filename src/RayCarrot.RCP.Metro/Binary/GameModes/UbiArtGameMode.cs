using BinarySerializer.UbiArt;

namespace RayCarrot.RCP.Metro;

public enum UbiArtGameMode
{
    [UbiArtGameModeInfo("Rayman Origins (PC)", BinarySerializer.UbiArt.Game.RaymanOrigins, Platform.PC)]
    RaymanOrigins_PC,

    [UbiArtGameModeInfo("Rayman Origins (PS3)", BinarySerializer.UbiArt.Game.RaymanOrigins, Platform.PlayStation3)]
    RaymanOrigins_PS3,

    [UbiArtGameModeInfo("Rayman Origins (Xbox 360)", BinarySerializer.UbiArt.Game.RaymanOrigins, Platform.Xbox360)]
    RaymanOrigins_Xbox360,

    [UbiArtGameModeInfo("Rayman Origins (Wii)", BinarySerializer.UbiArt.Game.RaymanOrigins, Platform.Wii)]
    RaymanOrigins_Wii,

    [UbiArtGameModeInfo("Rayman Origins (PS Vita)", BinarySerializer.UbiArt.Game.RaymanOrigins, Platform.PSVita)]
    RaymanOrigins_PSVita,

    [UbiArtGameModeInfo("Rayman Origins (3DS)", BinarySerializer.UbiArt.Game.RaymanOrigins, Platform.Nintendo3DS)]
    RaymanOrigins_3DS,

    [UbiArtGameModeInfo("Rayman Jungle Run (PC)", BinarySerializer.UbiArt.Game.RaymanJungleRun, Platform.PC)]
    RaymanJungleRun_PC,

    [UbiArtGameModeInfo("Rayman Jungle Run (Android)", BinarySerializer.UbiArt.Game.RaymanJungleRun, Platform.Android)]
    RaymanJungleRun_Android,

    [UbiArtGameModeInfo("Rayman Legends (PC)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.PC)]
    RaymanLegends_PC,

    [UbiArtGameModeInfo("Rayman Legends (PS3)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.PlayStation3)]
    RaymanLegends_PS3,

    [UbiArtGameModeInfo("Rayman Legends (Xbox 360)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.Xbox360)]
    RaymanLegends_Xbox360,

    [UbiArtGameModeInfo("Rayman Legends (Wii U)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.WiiU)]
    RaymanLegends_WiiU,

    [UbiArtGameModeInfo("Rayman Legends (PS Vita)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.PSVita)]
    RaymanLegends_PSVita,

    [UbiArtGameModeInfo("Rayman Legends (PS4)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.PlayStation4)]
    RaymanLegends_PS4,

    [UbiArtGameModeInfo("Rayman Legends (Xbox One)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.XboxOne)]
    RaymanLegends_XboxOne,

    [UbiArtGameModeInfo("Rayman Legends (Switch)", BinarySerializer.UbiArt.Game.RaymanLegends, Platform.NintendoSwitch)]
    RaymanLegends_Switch,

    [UbiArtGameModeInfo("Rayman Fiesta Run (PC)", BinarySerializer.UbiArt.Game.RaymanFiestaRun, Platform.PC)]
    RaymanFiestaRun_PC,

    [UbiArtGameModeInfo("Rayman Fiesta Run (Android)", BinarySerializer.UbiArt.Game.RaymanJungleRun, Platform.Android)]
    RaymanFiestaRun_Android,

    [UbiArtGameModeInfo("Rayman Adventures (Android)", BinarySerializer.UbiArt.Game.RaymanAdventures, Platform.Android)]
    RaymanAdventures_Android,

    [UbiArtGameModeInfo("Rayman Adventures (iOS)", BinarySerializer.UbiArt.Game.RaymanAdventures, Platform.iOS)]
    RaymanAdventures_iOS,

    [UbiArtGameModeInfo("Rayman Mini (Mac)", BinarySerializer.UbiArt.Game.RaymanMini, Platform.Mac)]
    RaymanMini_Mac,

    [UbiArtGameModeInfo("Child of Light (PC)", BinarySerializer.UbiArt.Game.ChildOfLight, Platform.PC)]
    ChildOfLight_PC,

    [UbiArtGameModeInfo("Child of Light (PS Vita)", BinarySerializer.UbiArt.Game.ChildOfLight, Platform.PSVita)]
    ChildOfLight_PSVita,

    [UbiArtGameModeInfo("Valiant Hearts (Android)", BinarySerializer.UbiArt.Game.ValiantHearts, Platform.Android)]
    ValiantHearts_Android,

    [UbiArtGameModeInfo("Just Dance 2014 (Wii U)", BinarySerializer.UbiArt.Game.JustDance2014, Platform.WiiU)]
    JustDance_2014_WiiU,

    [UbiArtGameModeInfo("Just Dance Japan (Wii U)", BinarySerializer.UbiArt.Game.JustDance2014JP, Platform.WiiU)]
    JustDance2014JP_WiiU,

    [UbiArtGameModeInfo("Yo-kai Watch Dance (Wii U)", BinarySerializer.UbiArt.Game.JustDanceYoKaiWatch, Platform.WiiU)]
    JustDanceYoKaiWatch_WiiU,

    [UbiArtGameModeInfo("Just Dance 2015 (Wii U)", BinarySerializer.UbiArt.Game.JustDance2015, Platform.WiiU)]
    JustDance_2015_WiiU,

    [UbiArtGameModeInfo("Just Dance 2016 (PS3)", BinarySerializer.UbiArt.Game.JustDance2016, Platform.PlayStation3)]
    JustDance_2016_PS3,

    [UbiArtGameModeInfo("Just Dance 2016 DEMO (Wii U)", BinarySerializer.UbiArt.Game.JustDance2016DEMO, Platform.WiiU)]
    JustDance_2016_DEMO_WiiU,

    [UbiArtGameModeInfo("Just Dance 2016 (Wii U)", BinarySerializer.UbiArt.Game.JustDance2016, Platform.WiiU)]
    JustDance_2016_WiiU,

    [UbiArtGameModeInfo("Just Dance 2017 DEMO (Wii U)", BinarySerializer.UbiArt.Game.JustDance2017DEMO, Platform.WiiU)]
    JustDance_2017_DEMO_WiiU,

    [UbiArtGameModeInfo("Just Dance 2017 (PC)", BinarySerializer.UbiArt.Game.JustDance2017, Platform.PC)]
    JustDance_2017_PC,

    [UbiArtGameModeInfo("Just Dance 2017 (Wii U)", BinarySerializer.UbiArt.Game.JustDance2017, Platform.WiiU)]
    JustDance_2017_WiiU,

    [UbiArtGameModeInfo("Just Dance 2018 DEMO (Wii U)", BinarySerializer.UbiArt.Game.JustDance2018DEMO, Platform.WiiU)]
    JustDance_2018_DEMO_WiiU,

    [UbiArtGameModeInfo("Just Dance 2018 (Wii U)", BinarySerializer.UbiArt.Game.JustDance2018, Platform.WiiU)]
    JustDance_2018_WiiU,

    [UbiArtGameModeInfo("Just Dance 2019 DEMO (Wii U)", BinarySerializer.UbiArt.Game.JustDance2019DEMO, Platform.WiiU)]
    JustDance_2019_DEMO_WiiU,

    [UbiArtGameModeInfo("Just Dance 2019 (Wii U)", BinarySerializer.UbiArt.Game.JustDance2019, Platform.WiiU)]
    JustDance_2019_WiiU,

    [UbiArtGameModeInfo("Just Dance 2020 (Wii)", BinarySerializer.UbiArt.Game.JustDance2020, Platform.Wii)]
    JustDance_2020_Wii,

    [UbiArtGameModeInfo("Just Dance 2020 (Switch)", BinarySerializer.UbiArt.Game.JustDance2020, Platform.NintendoSwitch)]
    JustDance_2020_Switch,

    [UbiArtGameModeInfo("Just Dance 2021 (Switch)", BinarySerializer.UbiArt.Game.JustDance2021, Platform.NintendoSwitch)]
    JustDance_2021_Switch,

    [UbiArtGameModeInfo("Just Dance 2022 (Switch)", BinarySerializer.UbiArt.Game.JustDance2022, Platform.NintendoSwitch)]
    JustDance_2022_Switch,

    [UbiArtGameModeInfo("Gravity Falls (3DS)", BinarySerializer.UbiArt.Game.GravityFalls, Platform.Nintendo3DS)]
    GravityFalls_3DS,
}