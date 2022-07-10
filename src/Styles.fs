namespace Feliz.ReactNative

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type style =
    static member inline height (value: float) = Interop.mkStyle "height" value
    static member inline height (value: string) = Interop.mkStyle "height" value
    static member inline width (value: float) = Interop.mkStyle "width" value
    static member inline width (value: string) = Interop.mkStyle "width" value
    static member inline maxHeight (value: float) = Interop.mkStyle "maxHeight" value
    static member inline maxHeight (value: string) = Interop.mkStyle "maxHeight" value
    static member inline maxWidth (value: float) = Interop.mkStyle "maxWidth" value
    static member inline maxWidth (value: string) = Interop.mkStyle "maxWidth" value
    static member inline minHeight (value: float) = Interop.mkStyle "minHeight" value
    static member inline minHeight (value: string) = Interop.mkStyle "minHeight" value
    static member inline minWidth (value: float) = Interop.mkStyle "minWidth" value
    static member inline minWidth (value: string) = Interop.mkStyle "minWidth" value
    static member inline backgroundColor(value: string) = Interop.mkStyle "backgroundColor" value
    static member inline elevation (value: float) = Interop.mkStyle "elevation" value
    static member inline opacity (value: float) = Interop.mkStyle "opacity" value
    /// Only on Android.
    static member inline overlayColor (value: string) = Interop.mkStyle "overlayColor" value
    static member inline tintColor (value: string) = Interop.mkStyle "tintColor" value

    // Border
    static member inline borderColor (value: string) = Interop.mkStyle "borderColor" value
    static member inline borderStartColor (value: string) = Interop.mkStyle "borderStartColor" value
    static member inline borderEndColor (value: string) = Interop.mkStyle "borderEndColor" value
    static member inline borderLeftColor (value: string) = Interop.mkStyle "borderLeftColor" value
    static member inline borderRightColor (value: string) = Interop.mkStyle "borderRightColor" value
    static member inline borderTopColor (value: float) = Interop.mkStyle "borderTopColor" value
    static member inline borderBottomColor (value: float) = Interop.mkStyle "borderBottomColor" value

    static member inline borderWidth (value: float) = Interop.mkStyle "borderWidth" value
    static member inline borderStartWidth (value: float) = Interop.mkStyle "borderStartWidth" value
    static member inline borderEndWidth (value: float) = Interop.mkStyle "borderEndWidth" value
    static member inline borderLeftWidth (value: float) = Interop.mkStyle "borderLeftWidth" value
    static member inline borderRightWidth (value: float) = Interop.mkStyle "borderRightWidth" value
    static member inline borderTopWidth (value: float) = Interop.mkStyle "borderTopWidth" value
    static member inline borderBottomWidth (value: float) = Interop.mkStyle "borderBottomWidth" value

    static member inline borderRadius (value: float) = Interop.mkStyle "borderRadius" value
    static member inline borderBottomStartRadius (value: float) = Interop.mkStyle "borderBottomStartRadius" value
    static member inline borderBottomEndRadius (value: float) = Interop.mkStyle "borderBottomEndRadius" value
    static member inline borderBottomLeftRadius (value: float) = Interop.mkStyle "borderBottomLeftRadius" value
    static member inline borderBottomRightRadius (value: float) = Interop.mkStyle "borderBottomRightRadius" value
    static member inline borderTopStartRadius (value: float) = Interop.mkStyle "borderTopStartRadius" value
    static member inline borderTopEndRadius (value: float) = Interop.mkStyle "borderTopEndRadius" value
    static member inline borderTopLeftRadius (value: float) = Interop.mkStyle "borderTopLeftRadius" value
    static member inline borderTopRightRadius (value: float) = Interop.mkStyle "borderTopRightRadius" value

    // Text
    static member inline color (value: string) = Interop.mkStyle "color" value
    static member inline fontFamily (value: string) = Interop.mkStyle "fontFamily" value
    static member inline fontSize (value: float) = Interop.mkStyle "fontSize" value
    /// Only on Android.
    static member inline includeFontPadding (value: bool) = Interop.mkStyle "includeFontPadding" value
    static member inline letterSpacing (value: float) = Interop.mkStyle "letterSpacing" value
    static member inline lineHeight (value: float) = Interop.mkStyle "lineHeight" value
    /// Only on iOS.
    static member inline textDecorationColor (value: string) = Interop.mkStyle "textDecorationColor" value
    static member inline textShadowColor (value: string) = Interop.mkStyle "textShadowColor" value
    static member inline textShadowOffset (width: float) (height: float) = Interop.mkStyle "textShadowOffset" {| width = width; height = height |}
    static member inline textShadowRadius (value: float) = Interop.mkStyle "textShadowRadius" value

    // Shadow
    static member inline shadowColor (value: string) = Interop.mkStyle "shadowColor" value
    /// Only on iOS.
    static member inline shadowOffset (width: float) (height: float) = Interop.mkStyle "shadowOffset" {| width = width; height = height |}
    /// Only on iOS.
    static member inline shadowOpacity (value: float) = Interop.mkStyle "shadowOpacity" value
    /// Only on iOS.
    static member inline shadowRadius (value: float) = Interop.mkStyle "shadowRadius" value

    // Layout
    static member inline aspectRatio (value: float) = Interop.mkStyle "aspectRatio" value

    static member inline flex (value: float) = Interop.mkStyle "flex" value
    static member inline flexBasis (value: float) = Interop.mkStyle "flexBasis" value
    static member inline flexGrow (value: float) = Interop.mkStyle "flexGrow" value
    static member inline flexShrink (value: float) = Interop.mkStyle "flexShrink" value

    static member inline start (value: float) = Interop.mkStyle "start" value
    static member inline start (value: string) = Interop.mkStyle "start" value
    static member inline end' (value: float) = Interop.mkStyle "end" value
    static member inline end' (value: string) = Interop.mkStyle "end" value
    static member inline top (value: float) = Interop.mkStyle "top" value
    static member inline top (value: string) = Interop.mkStyle "top" value
    static member inline bottom (value: float) = Interop.mkStyle "bottom" value
    static member inline bottom (value: string) = Interop.mkStyle "bottom" value
    static member inline left (value: float) = Interop.mkStyle "left" value
    static member inline left (value: string) = Interop.mkStyle "left" value
    static member inline right (value: float) = Interop.mkStyle "right" value
    static member inline right (value: string) = Interop.mkStyle "right" value

    static member inline margin (value: float) = Interop.mkStyle "margin" value
    static member inline margin (value: string) = Interop.mkStyle "margin" value
    static member inline marginVertical (value: float) = Interop.mkStyle "marginVertical" value
    static member inline marginVertical (value: string) = Interop.mkStyle "marginVertical" value
    static member inline marginHorizontal (value: float) = Interop.mkStyle "marginHorizontal" value
    static member inline marginHorizontal (value: string) = Interop.mkStyle "marginHorizontal" value
    static member inline marginStart (value: float) = Interop.mkStyle "marginStart" value
    static member inline marginStart (value: string) = Interop.mkStyle "marginStart" value
    static member inline marginEnd (value: float) = Interop.mkStyle "marginEnd" value
    static member inline marginEnd (value: string) = Interop.mkStyle "marginEnd" value
    static member inline marginTop (value: float) = Interop.mkStyle "marginTop" value
    static member inline marginTop (value: string) = Interop.mkStyle "marginTop" value
    static member inline marginBottom (value: float) = Interop.mkStyle "marginBottom" value
    static member inline marginBottom (value: string) = Interop.mkStyle "marginBottom" value
    static member inline marginLeft (value: float) = Interop.mkStyle "marginLeft" value
    static member inline marginLeft (value: string) = Interop.mkStyle "marginLeft" value
    static member inline marginRight (value: float) = Interop.mkStyle "marginRight" value
    static member inline marginRight (value: string) = Interop.mkStyle "marginRight" value

    static member inline padding (value: float) = Interop.mkStyle "padding" value
    static member inline padding (value: string) = Interop.mkStyle "padding" value
    static member inline paddingVertical (value: float) = Interop.mkStyle "paddingVertical" value
    static member inline paddingVertical (value: string) = Interop.mkStyle "paddingVertical" value
    static member inline paddingHorizontal (value: float) = Interop.mkStyle "paddingHorizontal" value
    static member inline paddingHorizontal (value: string) = Interop.mkStyle "paddingHorizontal" value
    static member inline paddingStart (value: float) = Interop.mkStyle "paddingStart" value
    static member inline paddingStart (value: string) = Interop.mkStyle "paddingStart" value
    static member inline paddingEnd (value: float) = Interop.mkStyle "paddingEnd" value
    static member inline paddingEnd (value: string) = Interop.mkStyle "paddingEnd" value
    static member inline paddingTop (value: float) = Interop.mkStyle "paddingTop" value
    static member inline paddingTop (value: string) = Interop.mkStyle "paddingTop" value
    static member inline paddingBottom (value: float) = Interop.mkStyle "paddingBottom" value
    static member inline paddingBottom (value: string) = Interop.mkStyle "paddingBottom" value
    static member inline paddingLeft (value: float) = Interop.mkStyle "paddingLeft" value
    static member inline paddingLeft (value: string) = Interop.mkStyle "paddingLeft" value
    static member inline paddingRight (value: float) = Interop.mkStyle "paddingRight" value
    static member inline paddingRight (value: string) = Interop.mkStyle "paddingRight" value

    static member inline transform (value: seq<ITransform>) = Interop.mkStyle "transform" (createObj !!value)

    static member inline zIndex (value: float) = Interop.mkStyle "zIndex" value


[<Erase>]
module style =
    [<Erase>]
    type backfaceVisibility =
        static member inline visible = Interop.mkStyle "backfaceVisibility" "visible"
        static member inline hidden = Interop.mkStyle "backfaceVisibility" "hidden"
    [<Erase>]
    type resizeMode =
        static member inline cover = Interop.mkStyle "resizeMode" "cover"
        static member inline contain = Interop.mkStyle "resizeMode" "contain"
        static member inline stretch = Interop.mkStyle "resizeMode" "stretch"
        static member inline repeat = Interop.mkStyle "resizeMode" "repeat"
        static member inline center = Interop.mkStyle "resizeMode" "center"

    // Text
    [<Erase>]
    type fontStyle =
        static member inline normal = Interop.mkStyle "fontStyle" "normal"
        static member inline italic = Interop.mkStyle "fontStyle" "italic"
    [<Erase>]
    type fontWeight =
        static member inline normal = Interop.mkStyle "fontWeight" "normal"
        static member inline bold = Interop.mkStyle "fontWeight" "bold"
        static member inline ``100`` = Interop.mkStyle "fontWeight" "100"
        static member inline ``200`` = Interop.mkStyle "fontWeight" "200"
        static member inline ``300`` = Interop.mkStyle "fontWeight" "300"
        static member inline ``400`` = Interop.mkStyle "fontWeight" "400"
        static member inline ``500`` = Interop.mkStyle "fontWeight" "500"
        static member inline ``600`` = Interop.mkStyle "fontWeight" "600"
        static member inline ``700`` = Interop.mkStyle "fontWeight" "700"
        static member inline ``800`` = Interop.mkStyle "fontWeight" "800"
        static member inline ``900`` = Interop.mkStyle "fontWeight" "900"
    [<Erase>]
    type fontVariant =
        static member inline smallCaps = Interop.mkStyle "fontVariant" "small-caps"
        static member inline oldstyleNums = Interop.mkStyle "fontVariant" "oldstyle-nums"
        static member inline liningNums = Interop.mkStyle "fontVariant" "lining-nums"
        static member inline tabularNums = Interop.mkStyle "fontVariant" "tabular-nums"
        static member inline proportionalsNums = Interop.mkStyle "fontVariant" "proportionals-nums"
    [<Erase>]
    type textAlign =
        static member inline auto = Interop.mkStyle "textAlign" "auto"
        static member inline left = Interop.mkStyle "textAlign" "left"
        static member inline right = Interop.mkStyle "textAlign" "right"
        static member inline center = Interop.mkStyle "textAlign" "center"
        static member inline justify = Interop.mkStyle "textAlign" "justify"
    [<Erase>]
    type textAlignVertical =
        /// Only on Android.
        static member inline auto = Interop.mkStyle "textAlignVertical" "auto"
        /// Only on Android.
        static member inline top = Interop.mkStyle "textAlignVertical" "top"
        /// Only on Android.
        static member inline bottom = Interop.mkStyle "textAlignVertical" "bottom"
        /// Only on Android.
        static member inline center = Interop.mkStyle "textAlignVertical" "center"
    [<Erase>]
    type textDecorationLine =
        static member inline none = Interop.mkStyle "textDecorationLine" "none"
        static member inline underline = Interop.mkStyle "textDecorationLine" "underline"
        static member inline lineThrough = Interop.mkStyle "textDecorationLine" "line-through"
        static member inline underlineLineThrough = Interop.mkStyle "textDecorationLine" "underline line-through"
    [<Erase>]
    type textDecorationStyle =
        /// Only on iOS.
        static member inline solid = Interop.mkStyle "textDecorationStyle" "solid"
        /// Only on iOS.
        static member inline double = Interop.mkStyle "textDecorationStyle" "double"
        /// Only on iOS.
        static member inline dotted = Interop.mkStyle "textDecorationStyle" "dotted"
        /// Only on iOS.
        static member inline dashed = Interop.mkStyle "textDecorationStyle" "dashed"
    [<Erase>]
    type textTransform =
        static member inline none = Interop.mkStyle "textTransform" "none"
        static member inline uppercase = Interop.mkStyle "textTransform" "uppercase"
        static member inline lowercase = Interop.mkStyle "textTransform" "lowercase"
        static member inline capitalize = Interop.mkStyle "textTransform" "capitalize"
    [<Erase>]
    type writingDirection =
        static member inline auto = Interop.mkStyle "writingDirection" "auto"
        static member inline ltr = Interop.mkStyle "writingDirection" "ltr"
        static member inline rtl = Interop.mkStyle "writingDirection" "rtl"

    // Layout
    [<Erase>]
    type alignContent =
        static member inline flexStart = Interop.mkStyle "alignContent" "flex-start"
        static member inline flexEnd = Interop.mkStyle "alignContent" "flex-end"
        static member inline center = Interop.mkStyle "alignContent" "center"
        static member inline stretch = Interop.mkStyle "alignContent" "stretch"
        static member inline spaceBetween = Interop.mkStyle "alignContent" "space-between"
        static member inline spaceAround = Interop.mkStyle "alignContent" "space-around"
    [<Erase>]
    type alignItems =
        static member inline flexStart = Interop.mkStyle "alignItems" "flex-start"
        static member inline flexEnd = Interop.mkStyle "alignItems" "flex-end"
        static member inline center = Interop.mkStyle "alignItems" "center"
        static member inline stretch = Interop.mkStyle "alignItems" "stretch"
        static member inline baseline = Interop.mkStyle "alignItems" "baseline"
    [<Erase>]
    type alignSelf =
        static member inline auto = Interop.mkStyle "alignSelf" "auto"
        static member inline flexStart = Interop.mkStyle "alignSelf" "flex-start"
        static member inline flexEnd = Interop.mkStyle "alignSelf" "flex-end"
        static member inline center = Interop.mkStyle "alignSelf" "center"
        static member inline stretch = Interop.mkStyle "alignSelf" "stretch"
        static member inline baseline = Interop.mkStyle "alignSelf" "baseline"
    [<Erase>]
    type direction =
        static member inline inherit' = Interop.mkStyle "direction" "inherit"
        static member inline ltr = Interop.mkStyle "direction" "ltr"
        static member inline rtl = Interop.mkStyle "direction" "rtl"
    [<Erase>]
    type display =
        static member inline none = Interop.mkStyle "display" "none"
        static member inline auto = Interop.mkStyle "display" "auto"
    [<Erase>]
    type flexDirection =
        static member inline row = Interop.mkStyle "flexDirection" "row"
        static member inline rowReverse = Interop.mkStyle "flexDirection" "row-reverse"
        static member inline column = Interop.mkStyle "flexDirection" "column"
        static member inline columnReverse = Interop.mkStyle "flexDirection" "column-reverse"
    [<Erase>]
    type flexWrap =
        static member inline wrap = Interop.mkStyle "flexWrap" "wrap"
        static member inline nowrap = Interop.mkStyle "flexWrap" "nowrap"
        static member inline wrapReverse = Interop.mkStyle "flexWrap" "wrap-reverse"
    [<Erase>]
    type justifyContent =
        static member inline flexStart = Interop.mkStyle "justifyContent" "flex-start"
        static member inline flexEnd = Interop.mkStyle "justifyContent" "flex-end"
        static member inline center = Interop.mkStyle "justifyContent" "center"
        static member inline spaceBetween = Interop.mkStyle "justifyContent" "space-between"
        static member inline spaceAround = Interop.mkStyle "justifyContent" "space-around"
        static member inline spaceEvenly = Interop.mkStyle "justifyContent" "space-evenly"
    [<Erase>]
    type overflow =
        static member inline visible = Interop.mkStyle "overflow" "visible"
        static member inline hidden = Interop.mkStyle "overflow" "hidden"
        static member inline scroll = Interop.mkStyle "overflow" "scroll"
    [<Erase>]
    type position =
        static member inline absolute = Interop.mkStyle "position" "absolute"
        static member inline relative = Interop.mkStyle "position" "relative"