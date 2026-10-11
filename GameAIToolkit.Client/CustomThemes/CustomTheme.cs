using MudBlazor;
namespace GameAIToolkit.CustomThemes
{
    public class CustomTheme
    {
            /* 
!
 * Bootswatch v5.3.3 (https://bootswatch.com)
 * Theme: spacelab
 * Copyright 2012-2024 Thomas Park
 * Licensed under MIT
 * Based on Bootstrap
    */ 
    public static readonly MudTheme Spacelabtheme = new()
    {
        PaletteLight = new PaletteLight()
        {
            // Backgrounds
            Surface = "#FFFFFF",
            Background = "#FAF9F7",
            BackgroundGray = "#F2EDE7",
            DrawerBackground = "#F2EDE7",
            AppbarBackground = "#FAF9F7",

            // Primary colours
            Primary = "#17151B",
            PrimaryDarken = "#0D0C10",
            PrimaryLighten = "#E9E7E5",
            PrimaryContrastText = "#FFFFFF",

            // Secondary colours
            Secondary = "#77747A",
            SecondaryDarken = "#555259",
            SecondaryLighten = "#EDEBE9",
            SecondaryContrastText = "#FFFFFF",

            // Text
            TextPrimary = "#17151B",
            TextSecondary = "#66636A",
            TextDisabled = "rgba(23,21,27,0.38)",

            // Drawer
            DrawerText = "#17151B",
            DrawerIcon = "#77747A",

            // Appbar
            AppbarText = "#17151B",

            // Dark
            Dark = "#252329",
            DarkDarken = "#17151B",
            DarkLighten = "#555259",
            DarkContrastText = "#FFFFFF",

            // Tertiary
            Tertiary = "#A7A3AA",
            TertiaryDarken = "#77747A",
            TertiaryLighten = "#D9D6DB",
            TertiaryContrastText = "#17151B",

            // Success
            Success = "#64B99A",
            SuccessDarken = "#368C6E",
            SuccessLighten = "#D8F2E8",
            SuccessContrastText = "#FFFFFF",

            // Info
            Info = "#8DAFCB",
            InfoDarken = "#547B9D",
            InfoLighten = "#E0EDF7",
            InfoContrastText = "#FFFFFF",

            // Warning
            Warning = "#E5B76B",
            WarningDarken = "#A66E25",
            WarningLighten = "#FBEDD5",
            WarningContrastText = "#17151B",

            // Error
            Error = "#E58D94",
            ErrorDarken = "#BF515D",
            ErrorLighten = "#FBE3E5",
            ErrorContrastText = "#FFFFFF",

            // Neutral colours
            White = "#FFFFFF",
            Black = "#17151B",
            GrayDarker = "#555259",
            GrayDark = "#77747A",
            GrayDefault = "#A7A3AA",
            GrayLight = "#D4D1CE",
            GrayLighter = "#EAE8E5",

            // Lines and dividers
            LinesDefault = "rgba(23,21,27,0.10)",
            LinesInputs = "rgba(23,21,27,0.20)",
            Divider = "#EAE8E5",
            DividerLight = "#F2EDE7",

            // Table styling
            TableHover = "rgba(23,21,27,0.035)",
            TableStriped = "rgba(23,21,27,0.018)",
            TableLines = "#EAE8E5",

            // Actions
            ActionDefault = "rgba(23,21,27,0.60)",
            ActionDisabled = "rgba(23,21,27,0.26)",
            ActionDisabledBackground = "rgba(23,21,27,0.08)",

            // Overlays
            OverlayLight = "rgba(255,255,255,0.50)",
            OverlayDark = "rgba(23,21,27,0.50)",

            // Opacity
            HoverOpacity = 0.06,
            RippleOpacity = 0.10,
            RippleOpacitySecondary = 0.20,
        },

        PaletteDark = new PaletteDark()
        {
            // Backgrounds
            Surface = "#29272D",
            Background = "#201F24",
            BackgroundGray = "#19181D",
            DrawerBackground = "#19181D",
            AppbarBackground = "#201F24",

            // Primary colours
            Primary = "#D8D4DE",
            PrimaryDarken = "#B9B3C2",
            PrimaryLighten = "#EEEAF2",
            PrimaryContrastText = "#201F24",

            // Secondary colours
            Secondary = "#AAA5B0",
            SecondaryDarken = "#8B8591",
            SecondaryLighten = "#D8D4DE",
            SecondaryContrastText = "#201F24",

            // Text
            TextPrimary = "#F1EFF3",
            TextSecondary = "#B8B4BE",
            TextDisabled = "rgba(241,239,243,0.30)",

            // Drawer
            DrawerText = "#F1EFF3",
            DrawerIcon = "#AAA5B0",

            // Appbar
            AppbarText = "#F1EFF3",

            // Dark
            Dark = "#19181D",
            DarkDarken = "#111015",
            DarkLighten = "#39363E",
            DarkContrastText = "#F1EFF3",

            // Tertiary
            Tertiary = "#A7A3AA",
            TertiaryDarken = "#77747A",
            TertiaryLighten = "#D9D6DB",
            TertiaryContrastText = "#201F24",

            // Success
            Success = "#83CEB0",
            SuccessDarken = "#64B99A",
            SuccessLighten = "#244D40",
            SuccessContrastText = "#19181D",

            // Info
            Info = "#A2C5E1",
            InfoDarken = "#8DAFCB",
            InfoLighten = "#293F50",
            InfoContrastText = "#19181D",

            // Warning
            Warning = "#F0C982",
            WarningDarken = "#D9AC62",
            WarningLighten = "#4A3821",
            WarningContrastText = "#19181D",

            // Error
            Error = "#F0A0A5",
            ErrorDarken = "#D67C84",
            ErrorLighten = "#4C292E",
            ErrorContrastText = "#19181D",

            // Neutral colours
            White = "#FFFFFF",
            Black = "#000000",
            GrayDarker = "#D8D4DE",
            GrayDark = "#B8B4BE",
            GrayDefault = "#8B8591",
            GrayLight = "#555259",
            GrayLighter = "#39363E",

            // Lines and dividers
            LinesDefault = "rgba(241,239,243,0.12)",
            LinesInputs = "rgba(241,239,243,0.30)",
            Divider = "rgba(241,239,243,0.12)",
            DividerLight = "rgba(241,239,243,0.06)",

            // Table styling
            TableHover = "rgba(255,255,255,0.05)",
            TableStriped = "rgba(255,255,255,0.025)",
            TableLines = "rgba(241,239,243,0.12)",

            // Actions
            ActionDefault = "rgba(241,239,243,0.65)",
            ActionDisabled = "rgba(241,239,243,0.26)",
            ActionDisabledBackground = "rgba(241,239,243,0.10)",

            // Overlays
            OverlayLight = "rgba(255,255,255,0.10)",
            OverlayDark = "rgba(0,0,0,0.50)",

            // Opacity
            HoverOpacity = 0.06,
            RippleOpacity = 0.10,
            RippleOpacitySecondary = 0.20,
        },
        // PaletteLight = new PaletteLight()
        // {
        //     TableHover = "rgba(0,0,0,0.0392156862745098)",
        //     OverlayLight = "rgba(255,255,255,0.4980392156862745)",
        //     OverlayDark = "rgba(33,33,33,0.4980392156862745)",
        //     GrayDarker = "#616161",
        //     GrayDark = "#757575",
        //     GrayLighter = "#E0E0E0",
        //     GrayLight = "#BDBDBD",
        //     GrayDefault = "#9E9E9E",
        //     RippleOpacitySecondary = 0.2,
        //     RippleOpacity = 0.1,
        //     HoverOpacity = 0.06,
        //     Surface = "rgba(255,255,255,1)",
        //     Background = "rgba(255,255,255,1)",
        //     BackgroundGray = "rgba(245,245,245,1)",
        //     ErrorContrastText = "rgba(255,255,255,1)",
        //     LinesInputs = "rgba(189,189,189,1)",
        //     ActionDisabled = "rgba(0,0,0,0.25882352941176473)",
        //     TextDisabled = "rgba(0,0,0,0.3764705882352941)",
        //     TableStriped = "rgba(0,0,0,0.0196078431372549)",
        //     LinesDefault = "rgba(0,0,0,0.11764705882352941)",
        //     ActionDisabledBackground = "rgba(0,0,0,0.11764705882352941)",
        //     TableLines = "rgba(224,224,224,1)",
        //     Divider = "rgba(224,224,224,1)",
        //     DividerLight = "rgba(0,0,0,0.8)",
        //     Error = "rgba(244,67,54,1)",
        //     TertiaryDarken = "rgba(119, 119, 119, 0.5)",
        //     Tertiary = "rgba(119, 119, 119, 0.5)",
        //     TertiaryLighten = "rgba(119, 119, 119, 0.5)",
        //     ActionDefault = "rgba(0,0,0,0.5372549019607843)",
        //     DarkLighten = "rgb(87,87,87)",
        //     ErrorLighten = "rgb(246,96,85)",
        //     ErrorDarken = "rgb(242,28,13)",
        //     DarkDarken = "rgb(46,46,46)",
        //     White = "#fff",
        //     WarningDarken = "#552f00",
        //     Warning = "#d47500",
        //     TextSecondary = "#3d3d3d",
        //     SecondaryDarken = "#3d3d3d",
        //     DarkContrastText = "#ced4da",
        //     Secondary = "#999",
        //     DrawerText = "#446e9bff",
        //     DrawerIcon = "#999",
        //     TextPrimary = "#1b2c3e",
        //     PrimaryDarken = "#1b2c3e",
        //     SuccessDarken = "#18480d",
        //     InfoDarken = "#143d61",
        //     Primary = "#446e9b",
        //     AppbarText = "#446e9bff",
        //     Success = "#3cb521",
        //     Info = "#3399f3",
        //     Dark = "#333",
        //     TertiaryContrastText = "#f8f9fa",
        //     WarningLighten = "#f6e3cc",
        //     WarningContrastText = "#f6e3cc",
        //     SecondaryLighten = "#ebebeb",
        //     SecondaryContrastText = "#ebebeb",
        //     DrawerBackground = "#ebebebff",
        //     PrimaryContrastText = "#dae2eb",
        //     PrimaryLighten = "#dae2eb",
        //     AppbarBackground = "#ecececff",
        //     SuccessContrastText = "#d8f0d3",
        //     SuccessLighten = "#d8f0d3",
        //     InfoContrastText = "#d6ebfd",
        //     InfoLighten = "#d6ebfd",
        //     Black = "#000",
        // },
        // PaletteDark = new PaletteDark()
        // {
        //     Surface = "rgba(55,55,64,1)",
        //     Background = "rgba(50,51,61,1)",
        //     BackgroundGray = "rgba(39,39,47,1)",
        //     ErrorContrastText = "rgba(255,255,255,1)",
        //     LinesInputs = "rgba(255,255,255,0.2980392156862745)",
        //     ActionDisabled = "rgba(255,255,255,0.25882352941176473)",
        //     TextDisabled = "rgba(255,255,255,0.2)",
        //     TableStriped = "rgba(255,255,255,0.2)",
        //     LinesDefault = "rgba(255,255,255,0.11764705882352941)",
        //     ActionDisabledBackground = "rgba(255,255,255,0.11764705882352941)",
        //     TableLines = "rgba(255,255,255,0.11764705882352941)",
        //     Divider = "rgba(255,255,255,0.11764705882352941)",
        //     DividerLight = "rgba(255,255,255,0.058823529411764705)",
        //     Error = "rgba(244,67,54,1)",
        //     TertiaryDarken = "rgba(222, 226, 230, 0.5)",
        //     Tertiary = "rgba(222, 226, 230, 0.5)",
        //     TertiaryLighten = "rgba(222, 226, 230, 0.5)",
        //     ActionDefault = "rgba(173,173,177,1)",
        //     DarkLighten = "rgb(56,56,67)",
        //     ErrorLighten = "rgb(246,96,85)",
        //     ErrorDarken = "rgb(242,28,13)",
        //     DarkDarken = "rgb(23,23,28)",
        //     White = "#fff",
        //     WarningDarken = "#e5ac66",
        //     Warning = "#d47500",
        //     TextSecondary = "#c2c2c2",
        //     SecondaryDarken = "#c2c2c2",
        //     DarkContrastText = "#c1c1c1ff",
        //     Secondary = "#999",
        //     DrawerText = "#999",
        //     DrawerIcon = "#999",
        //     TextPrimary = "#8fa8c3ff",
        //     PrimaryDarken = "#8fa8c3",
        //     SuccessDarken = "#8ad37a",
        //     InfoDarken = "#85c2f8",
        //     Primary = "#446e9bff",
        //     AppbarText = "#446e9b",
        //     Success = "#3cb521",
        //     Info = "#3399f3",
        //     Dark = "#333",
        //     TertiaryContrastText = "#303030",
        //     WarningLighten = "#2a1700",
        //     WarningContrastText = "#2a1700",
        //     SecondaryLighten = "#1f1f1f",
        //     SecondaryContrastText = "#1f1f1f",
        //     DrawerBackground = "#1f1f1f",
        //     PrimaryContrastText = "#0e161fff",
        //     PrimaryLighten = "#0e161fff",
        //     AppbarBackground = "#0e161f",
        //     SuccessContrastText = "#0c2407",
        //     SuccessLighten = "#0c2407",
        //     InfoContrastText = "#0a1f31",
        //     InfoLighten = "#0a1f31",
        //     Black = "#000",
        // },
        // LayoutProperties = new LayoutProperties()
        // {
        //     AppbarHeight = "64px",
        //     DefaultBorderRadius = "4px",
        //     DrawerMiniWidthLeft = "56px",
        //     DrawerMiniWidthRight = "56px",
        //     DrawerWidthLeft = "240px",
        //     DrawerWidthRight = "240px",
        // },
        Typography = new Typography()
        {
            Default = new DefaultTypography
            {
                FontFamily = ["Montserrat", "sans-serif"],
                FontWeight = "400",
                FontSize = ".875rem",
                LineHeight = "1.43",
                LetterSpacing = ".01071em",
                TextTransform = "none",
            },
            H1 = new H1Typography
            {
                FontWeight = "300",
                FontSize = "6rem",
                LineHeight = "1.167",
                LetterSpacing = "-.01562em",
                TextTransform = "none",
            },
            H2 = new H2Typography
            {
                FontWeight = "300",
                FontSize = "3.75rem",
                LineHeight = "1.2",
                LetterSpacing = "-.00833em",
                TextTransform = "none",
            },
            H3 = new H3Typography
            {
                FontWeight = "400",
                FontSize = "3rem",
                LineHeight = "1.167",
                LetterSpacing = "0",
                TextTransform = "none",
            },
            H4 = new H4Typography
            {
                FontWeight = "400",
                FontSize = "2.125rem",
                LineHeight = "1.235",
                LetterSpacing = ".00735em",
                TextTransform = "none",
            },
            H5 = new H5Typography
            {
                FontWeight = "400",
                FontSize = "1.5rem",
                LineHeight = "1.334",
                LetterSpacing = "0",
                TextTransform = "none",
            },
            H6 = new H6Typography
            {
                FontWeight = "500",
                FontSize = "1.25rem",
                LineHeight = "1.6",
                LetterSpacing = ".0075em",
                TextTransform = "none",
            },
            Subtitle1 = new Subtitle1Typography
            {
                FontWeight = "400",
                FontSize = "1rem",
                LineHeight = "1.75",
                LetterSpacing = ".00938em",
                TextTransform = "none",
            },
            Subtitle2 = new Subtitle2Typography
            {
                FontWeight = "500",
                FontSize = ".875rem",
                LineHeight = "1.57",
                LetterSpacing = ".00714em",
                TextTransform = "none",
            },
            Body1 = new Body1Typography
            {
                FontWeight = "400",
                FontSize = "1rem",
                LineHeight = "1.5",
                LetterSpacing = ".00938em",
                TextTransform = "none",
            },
            Body2 = new Body2Typography
            {
                FontWeight = "400",
                FontSize = ".875rem",
                LineHeight = "1.43",
                LetterSpacing = ".01071em",
                TextTransform = "none",
            },
            Button = new ButtonTypography
            {
                FontWeight = "500",
                FontSize = ".875rem",
                LineHeight = "1.75",
                LetterSpacing = ".02857em",
                TextTransform = "uppercase",
            },
            Caption = new CaptionTypography
            {
                FontWeight = "400",
                FontSize = ".75rem",
                LineHeight = "1.66",
                LetterSpacing = ".03333em",
                TextTransform = "none",
            },
            Overline = new OverlineTypography
            {
                FontWeight = "400",
                FontSize = ".75rem",
                LineHeight = "2.66",
                LetterSpacing = ".08333em",
                TextTransform = "none",
            },
        },
        ZIndex = new ZIndex()
        {
            AppBar = 1300,
            Dialog = 1400,
            Drawer = 1100,
            Popover = 1200,
            Snackbar = 1500,
            Tooltip = 1600,
        },
    };

}}