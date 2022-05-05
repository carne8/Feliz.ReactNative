namespace Feliz.ReactNative

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type prop =
    // View props
    static member inline accessibilityActions (value: AccessibilityActions []) = Interop.mkAttr "accessibilityActions" value
    /// Only on iOS.
    static member inline accessibilityElementsHidden (value: bool) = Interop.mkAttr "accessibilityElementsHidden" value
    static member inline accessibilityHint (value: string) = Interop.mkAttr "accessibilityHint" value
    /// Only on iOS.
    static member inline accessibilityLanguage (value: string) = Interop.mkAttr "accessibilityLanguage" value
    /// Only on iOS.
    static member inline accessibilityIgnoresInvertColors (value: bool) = Interop.mkAttr "accessibilityIgnoresInvertColors" value
    static member inline accessibilityLabel (value: string) = Interop.mkAttr "accessibilityLabel" value
    static member inline accessibilityState (value: {| disabled: bool option; selected: bool option; ``checked``: bool option; busy: bool option; expanded: bool option |}) =
        [ "disabled" ==> Option.defaultValue !!Interop.undefined value.disabled
          "selected" ==> Option.defaultValue !!Interop.undefined value.selected
          "checked" ==> Option.defaultValue !!Interop.undefined value.``checked``
          "busy" ==> Option.defaultValue !!Interop.undefined value.busy
          "expanded" ==> Option.defaultValue !!Interop.undefined value.expanded ]
        |> createObj
        |> Interop.mkAttr "accessibilityState"
    static member inline accessibilityState (value: {| disabled: bool option; selected: bool option; ``checked``: string option; busy: bool option; expanded: bool option |}) =
        [ "disabled" ==> Option.defaultValue !!Interop.undefined value.disabled
          "selected" ==> Option.defaultValue !!Interop.undefined value.selected
          "checked" ==> Option.defaultValue !!Interop.undefined value.``checked``
          "busy" ==> Option.defaultValue !!Interop.undefined value.busy
          "expanded" ==> Option.defaultValue !!Interop.undefined value.expanded ]
        |> createObj
        |> Interop.mkAttr "accessibilityState"
    static member inline accessibilityValue (value: {| min: float; max: float; now: float; text: string |}) = Interop.mkAttr "accessibilityValue" value
    /// Only on iOS.
    static member inline accessibilityViewIsModal (value: bool) = Interop.mkAttr "accessibilityViewIsModal" value
    static member inline accessible (value: bool) = Interop.mkAttr "accessible" value
    static member inline children (value: ReactElement) = Interop.mkAttr "children" value
    static member inline children (elems: ReactElement seq) = Interop.mkAttr "children" (Feliz.Interop.reactApi.Children.toArray (Array.ofSeq elems))
    static member inline collapsable (value: bool) = Interop.mkAttr "collapsable" value
    static member inline focusable (value: bool) = Interop.mkAttr "focusable" value
    /// `prop.hitSlop 10.` is same as `prop.hitSlop (10., 10., 10., 10.)`
    static member inline hitSlop (value: float) = Interop.mkAttr "hitSlop" {| top = value; bottom = value; left = value; right = value |}
    static member inline hitSlop (top: float, bottom: float, left: float, right: float) = Interop.mkAttr "hitSlop" {| top = top; bottom = bottom; left = left; right = right |}
    static member inline nativeID (value: string) = Interop.mkAttr "nativeID" value
    static member inline needsOffscreenAlphaCompositing (value: bool) = Interop.mkAttr "needsOffscreenAlphaCompositing" value
    /// Only on Android.
    static member inline nextFocusDown (value: float) = Interop.mkAttr "nextFocusDown" value
    /// Only on Android.
    static member inline nextFocusForward (value: float) = Interop.mkAttr "nextFocusForward" value
    /// Only on Android.
    static member inline nextFocusLeft (value: float) = Interop.mkAttr "nextFocusLeft" value
    /// Only on Android.
    static member inline nextFocusRight (value: float) = Interop.mkAttr "nextFocusRight" value
    /// Only on Android.
    static member inline nextFocusUp (value: float) = Interop.mkAttr "nextFocusUp" value
    static member inline onAccessibilityActions (value: AccessibilityActions -> unit) = Interop.mkAttr "onAccessibilityActions" value
    /// Only on iOS.
    static member inline onAccessibilityEscape (value: unit -> unit) = Interop.mkAttr "onAccessibilityEscape" value
    static member inline onAccessibilityTap (value: unit -> unit) = Interop.mkAttr "onAccessibilityTap" value
    static member inline onLayout (value: {| nativeEvent: LayoutEvent |} -> unit) = Interop.mkAttr "onLayout" value
    /// Only on iOS.
    static member inline onMagicTap (value: unit -> unit) = Interop.mkAttr "omMagicTap" value
    static member inline onMoveShouldSetResponder (value: {| nativeEvent: PressEvent |} -> bool) = Interop.mkAttr "onMoveShouldSetResponder" value
    static member inline onMoveShouldSetResponderCapture (value: {| nativeEvent: PressEvent |} -> bool) = Interop.mkAttr "onMoveShouldSetResponderCapture" value
    static member inline onResponderGrant (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onResponderGrant" value
    static member inline onResponderMove (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onResponderMove" value
    static member inline onResponderReject (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onResponderReject" value
    static member inline onResponderRelease (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onResponderRelease" value
    static member inline onResponderTerminate (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onResponderTerminate" value
    static member inline onResponderTerminationRequest (value: {| nativeEvent: PressEvent |} -> bool) = Interop.mkAttr "onResponderTerminationRequest" value
    static member inline onStartShouldSetResponder (value: {| nativeEvent: PressEvent |} -> bool) = Interop.mkAttr "onStartShouldSetResponder" value
    static member inline onStartShouldSetResponderCapture (value: {| nativeEvent: PressEvent |} -> bool) = Interop.mkAttr "onStartShouldSetResponderCapture" value
    static member inline removeClippedSubviews (value: bool) = Interop.mkAttr "removeClippedSubviews" value
    /// Only on Android.
    static member inline renderToHardwareTextureAndroid (value: bool) = Interop.mkAttr "renderToHardwareTextureAndroid " value
    /// Only on iOS.
    static member inline shouldRasterizeIOS (value: bool) = Interop.mkAttr "shouldRasterizeIOS " value
    static member inline style (properties: Feliz.IStyleAttribute list) = Interop.mkAttr "style" (createObj !!properties)
    static member inline testID (value: string) = Interop.mkAttr "testID" value

    // Text props
    static member inline adjustsFontSizeToFit (value: bool) = Interop.mkAttr "adjustsFontSizeToFit" value
    static member inline allowFontScaling (value: bool) = Interop.mkAttr "allowFontScaling" value
    /// Only on Android.
    static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
    static member inline maxFontSizeMultiplier (value: float) = Interop.mkAttr "maxFontSizeMultiplier" value
    static member inline maxFontSizeMultiplier (value: obj) = Interop.mkAttr "maxFontSizeMultiplier" value
    /// Only on iOS.
    static member inline minimumFontScale (value: float) = Interop.mkAttr "minimumFontScale" value
    static member inline numberOfLines (value: float) = Interop.mkAttr "numberOfLines" value
    static member inline onLongPress (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onLongPress" value
    static member inline onPress (value: {| nativeEvent: PressEvent |} -> unit) = Interop.mkAttr "onPress" value
    static member inline onTextLayout (value: TextLayoutEvent -> 'a) = Interop.mkAttr "onTextLayout" value
    static member inline pressRetentionOffset (value: Rect) = Interop.mkAttr "pressRetentionOffset" value
    static member inline pressRetentionOffset (value: float) = Interop.mkAttr "pressRetentionOffset" value
    static member inline selectable (value: bool) = Interop.mkAttr "selectable" value
    /// Only on Android.
    static member inline selectionColor (value: string) = Interop.mkAttr "selectionColor" value
    /// Only on iOS.
    static member inline suppressHighlighting (value: string) = Interop.mkAttr "suppressHighlighting" value
    static member inline text (value: string) = Interop.mkAttr "children" value


[<Erase>]
module prop =
    [<Erase>]
    type accessibilityLiveRegion =
        static member inline none = Interop.mkAttr "accessibilityLiveRegion" "none"
        static member inline polite = Interop.mkAttr "accessibilityLiveRegion" "polite"
        static member inline assertive = Interop.mkAttr "accessibilityLiveRegion" "assertive"
    [<Erase>]
    type accessibilityRole =
        static member inline adjustable = Interop.mkAttr "accessibilityRole" "adjustable"
        static member inline alert = Interop.mkAttr "accessibilityRole" "alert"
        static member inline button = Interop.mkAttr "accessibilityRole" "button"
        static member inline checkbox = Interop.mkAttr "accessibilityRole" "checkbox"
        static member inline combobox = Interop.mkAttr "accessibilityRole" "combobox"
        static member inline header = Interop.mkAttr "accessibilityRole" "header"
        static member inline image = Interop.mkAttr "accessibilityRole" "image"
        static member inline imagebutton = Interop.mkAttr "accessibilityRole" "imagebutton"
        static member inline keyboardkey = Interop.mkAttr "accessibilityRole" "keyboardkey"
        static member inline link = Interop.mkAttr "accessibilityRole" "link"
        static member inline menu = Interop.mkAttr "accessibilityRole" "menu"
        static member inline menubar = Interop.mkAttr "accessibilityRole" "menubar"
        static member inline menuitem = Interop.mkAttr "accessibilityRole" "menuitem"
        static member inline none = Interop.mkAttr "accessibilityRole" "none"
        static member inline progressbar = Interop.mkAttr "accessibilityRole" "progressbar"
        static member inline radio = Interop.mkAttr "accessibilityRole" "radio"
        static member inline radiogroup = Interop.mkAttr "accessibilityRole" "radiogroup"
        static member inline scrollbar = Interop.mkAttr "accessibilityRole" "scrollbar"
        static member inline search = Interop.mkAttr "accessibilityRole" "search"
        static member inline spinbutton = Interop.mkAttr "accessibilityRole" "spinbutton"
        static member inline summary = Interop.mkAttr "accessibilityRole" "summary"
        static member inline switch = Interop.mkAttr "accessibilityRole" "switch"
        static member inline tab = Interop.mkAttr "accessibilityRole" "tab"
        static member inline tablist = Interop.mkAttr "accessibilityRole" "tablist"
        static member inline text = Interop.mkAttr "accessibilityRole" "text"
        static member inline timer = Interop.mkAttr "accessibilityRole" "timer"
        static member inline togglebutton = Interop.mkAttr "accessibilityRole" "togglebutton"
        static member inline toolbar = Interop.mkAttr "accessibilityRole" "toolbar"
    [<Erase>]
    type android_hyphenationFrequency =
        /// Only on Android.
        static member inline none = Interop.mkAttr "android_hyphenationFrequency" "none"
        /// Only on Android.
        static member inline normal = Interop.mkAttr "android_hyphenationFrequency" "normal"
        /// Only on Android.
        static member inline full = Interop.mkAttr "android_hyphenationFrequency" "full"
    [<Erase>]
    type dataDetectorType =
        /// Only on Android.
        static member inline none = Interop.mkAttr "dataDetectorType" "none"
        /// Only on Android.
        static member inline phoneNumber = Interop.mkAttr "dataDetectorType" "phoneNumber"
        /// Only on Android.
        static member inline link = Interop.mkAttr "dataDetectorType" "link"
        /// Only on Android.
        static member inline email = Interop.mkAttr "dataDetectorType" "email"
        /// Only on Android.
        static member inline all = Interop.mkAttr "dataDetectorType" "all"
    [<Erase>]
    type ellipsizeMode =
        static member inline head = Interop.mkAttr "ellipsizeMode" "head"
        static member inline middle = Interop.mkAttr "ellipsizeMode" "middle"
        static member inline tail = Interop.mkAttr "ellipsizeMode" "tail"
        static member inline clip = Interop.mkAttr "ellipsizeMode" "clip"
    [<Erase>]
    type importantForAccessibility =
        static member inline auto = Interop.mkAttr "importantForAccessibility" "auto"
        static member inline yes = Interop.mkAttr "importantForAccessibility" "yes"
        static member inline no = Interop.mkAttr "importantForAccessibility" "no"
        static member inline noHideDescendants = Interop.mkAttr "importantForAccessibility" "no-hide-descendants"
    [<Erase>]
    type pointerEvents =
        static member inline auto = Interop.mkAttr "pointerEvents" "auto"
        static member inline none = Interop.mkAttr "pointerEvents" "none"
        static member inline boxNone = Interop.mkAttr "pointerEvents" "box-none"
        static member inline boxOnly = Interop.mkAttr "pointerEvents" "box-only"
    [<Erase>]
    type textBreakStrategy =
        /// Only on Android.
        static member inline simple = Interop.mkAttr "textBreakStrategy" "simple"
        /// Only on Android.
        static member inline hightQuality = Interop.mkAttr "textBreakStrategy" "hightQuality"
        /// Only on Android.
        static member inline balanced = Interop.mkAttr "textBreakStrategy" "balanced"