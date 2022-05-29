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
    static member inline accessibilityLabel (value: string) = Interop.mkAttr "accessibilityLabel" value
    /// Only on iOS.
    static member inline accessibilityLanguage (value: string) = Interop.mkAttr "accessibilityLanguage" value
    /// Only on iOS.
    static member inline accessibilityIgnoresInvertColors (value: bool) = Interop.mkAttr "accessibilityIgnoresInvertColors" value
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
    static member inline hitSlop (value: float) = Interop.mkAttr "hitSlop" value
    static member inline hitSlop (value: seq<IRect>) = Interop.mkAttr "hitSlop" (createObj !!value)
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
    static member inline style (properties: seq<IStyleAttribute>) = Interop.mkAttr "style" (createObj !!properties)
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
    static member inline pressRetentionOffset (value: seq<IRect>) = Interop.mkAttr "pressRetentionOffset" (createObj !!value)
    static member inline pressRetentionOffset (value: float) = Interop.mkAttr "pressRetentionOffset" value
    static member inline selectable (value: bool) = Interop.mkAttr "selectable" value
    /// Only on Android.
    static member inline selectionColor (value: string) = Interop.mkAttr "selectionColor" value
    /// Only on iOS.
    static member inline suppressHighlighting (value: string) = Interop.mkAttr "suppressHighlighting" value
    static member inline text (value: string) = Interop.mkAttr "children" value

    // Image props
    static member inline blurRadius (value: float) = Interop.mkAttr "blurRadius" value
    /// Only on iOS.
    static member inline capInsets (value: seq<IRect>) = Interop.mkAttr "capInsets" (createObj !!value)
    static member inline defaultSource (value: IImageSource) = Interop.mkAttr "defaultSource" value
    static member inline defaultSource (value: seq<IImageSourceProp>) = Interop.mkAttr "defaultSource" (createObj !!value)
    /// Only on Android.
    static member inline fadeDuration (value: float) = Interop.mkAttr "fadeDuration" value
    static member inline loadingIndicatorSource (uri: string) = Interop.mkAttr "loadingIndicatorSource" (createObj [ "uri" ==> uri ])
    static member inline onError (value: {| nativeEvent: obj |} -> unit) = Interop.mkAttr "onError" value
    static member inline onLoad (value: {| nativeEvent: ImageLoadEvent |} -> unit) = Interop.mkAttr "onLoad" value
    static member inline onLoadEnd (value: unit -> unit) = Interop.mkAttr "onLoadEnd" value
    static member inline onLoadStart (value: unit -> unit) = Interop.mkAttr "onLoadStart" value
    /// Only on iOS.
    static member inline onPartialLoad (value: unit -> unit) = Interop.mkAttr "onPartialLoad" value
    static member inline onProgress (value: {| nativeEvent: {| loaded: float; total: float |} |} -> unit) = Interop.mkAttr "onProgress" value
    /// Only on Android.
    static member inline progressiveRenderingEnabled (value: bool) = Interop.mkAttr "progressiveRenderingEnabled" value
    static member inline source (value: IImageSource) = Interop.mkAttr "source" value
    static member inline source (value: seq<IImageSourceProp>) = Interop.mkAttr "source" (createObj !!value)

    // Text input
    static member inline autoCorrect (value: bool) = Interop.mkAttr "autoCorrect" value
    static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
    static member inline blurOnSubmit (value: bool) = Interop.mkAttr "blurOnSubmit" value
    static member inline caretHidden (value: bool) = Interop.mkAttr "caretHidden" value
    /// Only on iOS.
    static member inline clearTextOnFocus (value: bool) = Interop.mkAttr "clearTextOnFocus" value
    static member inline contextMenuHidden (value: bool) = Interop.mkAttr "contextMenuHidden" value
    static member inline defaultValue (value: string) = Interop.mkAttr "defaultValue" value
    /// Only on Android.
    static member inline disableFullscreenUI (value: bool) = Interop.mkAttr "disableFullscreenUI" value
    static member inline editable (value: bool) = Interop.mkAttr "editable" value
    /// Only on iOS.
    static member inline enableReturnKeyAutomatically (value: bool) = Interop.mkAttr "enableReturnKeyAutomatically" value
    /// Only on Android.
    static member inline inlineImageLeft (value: string) = Interop.mkAttr "inlineImageLeft" value
    /// Only on Android.
    static member inline inlineImagePadding (value: string) = Interop.mkAttr "inlineImagePadding" value
    /// Only on iOS.
    static member inline inputAccessoryViewID (value: string) = Interop.mkAttr "inputAccessoryViewID" value
    static member inline maxLength (value: float) = Interop.mkAttr "maxLength" value
    static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
    static member inline onBlur (value: unit -> unit) = Interop.mkAttr "onChange" value
    static member inline onChange (value: {| nativeEvent: {| eventCount: int; target: int; text: string |} |} -> unit) = Interop.mkAttr "onChange" value
    static member inline onChangeText (value: string -> unit) = Interop.mkAttr "onChangeText" value
    static member inline onContentSizeChange (value: {| nativeEvent: {| contentSize: {| width: float; height: float |} |} |} -> unit) = Interop.mkAttr "onContentSizeChange" value
    static member inline onEndEditing (value: unit -> unit) = Interop.mkAttr "onEndEditing" value
    static member inline onFocus (value: {| nativeEvent: LayoutEvent |} -> unit) = Interop.mkAttr "onFocus" value
    static member inline onKeyPress (value: {| nativeEvent: {| key: string |} |} -> unit) = Interop.mkAttr "onKeyPress" value
    static member inline onScroll
        (value:
            {| nativeEvent:
                {| contentOffset: {| x: float; y: float |}
                   contentInset: {| bottom: float; left: float; right: float; top: float |}
                   contentSize: {| height: float; width: float |} |} |} -> unit) =
        Interop.mkAttr "onScroll" value
    static member inline onSelectionChange (value: {| nativeEvent: {| selection: {| start: int; ``end``: int |} |} |} -> unit) = Interop.mkAttr "onSelectionChange" value
    static member inline onSubmitEditing (value: {| nativeEvent: {| eventCount: int; target: int; text: string |} |} -> unit) = Interop.mkAttr "onSubmitEditing" value
    static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
    static member inline placeholderTextColor (value: string) = Interop.mkAttr "placeholderTextColor" value
    /// Only on Android.
    static member inline returnKeyLabel (value: string) = Interop.mkAttr "returnKeyLabel" value
    /// Only on iOS.
    static member inline rejectResponderTermination (value: bool) = Interop.mkAttr "rejectResponderTermination" value
    /// Only on iOS.
    static member inline scrollEnabled (value: bool) = Interop.mkAttr "scrollEnabled" value
    static member inline secureTextEntry (value: bool) = Interop.mkAttr "secureTextEntry" value
    static member inline selection (value: {| start: int; ``end``: int |}) = Interop.mkAttr "selection" value
    static member inline selectTextOnFocus (value: bool) = Interop.mkAttr "selectTextOnFocus" value
    static member inline showSoftInputOnFocus (value: bool) = Interop.mkAttr "showSoftInputOnFocus" value
    /// Only on iOS.
    static member inline spellCheck (value: bool) = Interop.mkAttr "spellCheck" value
    /// Only on iOS.
    static member inline passwordRules (value: string) = Interop.mkAttr "passwordRules" value
    /// Only on Android.
    static member inline underlineColorAndroid (value: string) = Interop.mkAttr "underlineColorAndroid" value
    static member inline value (value: string) = Interop.mkAttr "value" value

    // ScrollView
    static member inline stickyHeaderComponent (value: seq<ReactElement>) = Interop.mkAttr "StickyHeaderComponent" value
    static member inline stickyHeaderComponent (value: ReactElement) = Interop.mkAttr "StickyHeaderComponent" value
    /// Only on iOS.
    static member inline alwaysBounceHorizontal (value: bool) = Interop.mkAttr "alwaysBounceHorizontal" value
    /// Only on iOS.
    static member inline alwaysBounceVertical (value: bool) = Interop.mkAttr "alwaysBounceVertical" value
    /// Only on iOS.
    static member inline automaticallyAdjustContentInsets (value: bool) = Interop.mkAttr "automaticallyAdjustContentInsets" value
    /// Only on iOS.
    static member inline automaticallyAdjustsScrollIndicatorInsets (value: bool) = Interop.mkAttr "automaticallyAdjustsScrollIndicatorInsets" value
    /// Only on iOS.
    static member inline bounces (value: bool) = Interop.mkAttr "bounces" value
    /// Only on iOS.
    static member inline bouncesZoom (value: bool) = Interop.mkAttr "bouncesZoom" value
    /// Only on iOS.
    static member inline canCancelContentTouches (value: bool) = Interop.mkAttr "canCancelContentTouches" value
    /// Only on iOS.
    static member inline centerContent (value: bool) = Interop.mkAttr "centerContent" value
    static member inline contentContainerStyle (value: seq<IStyleAttribute>) = Interop.mkAttr "contentContainerStyle" value
    /// Only on iOS.
    static member inline contentInset (top: float, bottom: float, left: float, right: float) = Interop.mkAttr "contentInset" {| top = top; bottom = bottom; left = left; right = right |}
    static member inline contentOffset (value: {| x: float; y: float |}) = Interop.mkAttr "contentOffset" value
    static member inline decelerationRate (value: float) = Interop.mkAttr "decelerationRate" value
    static member inline directionalLockEnabled (value: bool) = Interop.mkAttr "directionalLockEnabled" value
    static member inline disableIntervalMomentum (value: bool) = Interop.mkAttr "disableIntervalMomentum" value
    static member inline disableScrollViewPanResponder (value: bool) = Interop.mkAttr "disableScrollViewPanResponder" value
    /// Only on Android.
    static member inline endFillColor (value: string) = Interop.mkAttr "endFillColor" value
    /// Only on Android.
    static member inline fadingEdgeLength (value: float) = Interop.mkAttr "fadingEdgeLength" value
    static member inline horizontal (value: bool) = Interop.mkAttr "horizontal" value
    static member inline invertStickyHeaders (value: bool) = Interop.mkAttr "invertStickyHeaders" value
    static member inline maintainVisibleContentPosition (value: {| minIndexForVisible: float; autoscrollToTopThreshold: float |}) = Interop.mkAttr "maintainVisibleContentPosition" value
    /// Only on iOS.
    static member inline maximumZoomScale (value: float) = Interop.mkAttr "maximumZoomScale" value
    /// Only on iOS.
    static member inline minimumZoomScale (value: float) = Interop.mkAttr "minimumZoomScale" value
    /// Only on Android.
    static member inline nestedScrollEnabled (value: bool) = Interop.mkAttr "nestedScrollEnabled" value
    static member inline onContentSizeChange (value: (float * float) -> unit) = Interop.mkAttr "onContentSizeChange" value
    static member inline onMomentumScrollBegin (value: unit -> unit) = Interop.mkAttr "onMomentumScrollBegin" value
    static member inline onMomentumScrollEnd (value: unit -> unit) = Interop.mkAttr "onMomentumScrollEnd" value
    static member inline onScrollBeginDrag (value: unit -> unit) = Interop.mkAttr "onScrollBeginDrag" value
    static member inline onScrollEndDrag (value: unit -> unit) = Interop.mkAttr "onScrollEndDrag" value
    /// Only on iOS.
    static member inline onScrollToTop (value: unit -> unit) = Interop.mkAttr "onScrollToTop" value
    static member inline pagingEnabled (value: bool) = Interop.mkAttr "pagingEnabled" value
    /// Only on Android.
    static member inline persistentScrollbar (value: bool) = Interop.mkAttr "persistentScrollbar" value
    /// Only on iOS.
    static member inline pinchGestureEnabled (value: bool) = Interop.mkAttr "pinchGestureEnabled" value
    static member inline refreshControl (value: ReactElement) = Interop.mkAttr "refreshControl" value
    /// Only on iOS.
    static member inline scrollEventThrottle (value: float) = Interop.mkAttr "scrollEventThrottle" value
    /// Only on iOS.
    static member inline scrollIndicatorInsets (top: float, bottom: float, left: float, right: float) = Interop.mkAttr "scrollIndicatorInsets" {| top = top; bottom = bottom; left = left; right = right |}
    /// Only on Android.
    static member inline scrollPerfTag (value: string) = Interop.mkAttr "scrollPerfTag" value
    /// Only on iOS.
    static member inline scrollToOverflowEnabled (value: bool) = Interop.mkAttr "scrollToOverflowEnabled" value
    /// Only on iOS.
    static member inline scrollsToTop (value: bool) = Interop.mkAttr "scrollsToTop" value
    static member inline showsHorizontalScrollIndicator (value: bool) = Interop.mkAttr "showsHorizontalScrollIndicator" value
    static member inline showsVerticalScrollIndicator (value: bool) = Interop.mkAttr "showsVerticalScrollIndicator" value
    static member inline snapToEnd (value: bool) = Interop.mkAttr "snapToEnd" value
    static member inline snapToIntervale (value: float) = Interop.mkAttr "snapToIntervale" value
    static member inline snapToOffsets (value: seq<float>) = Interop.mkAttr "snapToOffsets" value
    static member inline snapToStart (value: seq<float>) = Interop.mkAttr "snapToStart" value
    static member inline stickyHeaderHiddenOnScroll (value: bool) = Interop.mkAttr "snapToStartstickyHeaderHiddenOnScroll" value
    static member inline stickyHeaderIndices (value: seq<float>) = Interop.mkAttr "stickyHeaderIndices" value
    /// Only on iOS.
    static member inline zoomScale (value: float) = Interop.mkAttr "zoomScale" value

    // FlatList
    static member inline renderItem
        (value:
            {| item: 'Item
               index: int
               separators:
                    {| highlight: unit -> unit
                       unhighlight: unit -> unit
                       updateProps: unit -> unit
                       select: string
                       newProps: _ |} |}
            -> ReactElement)
        =
        Interop.mkAttr "renderItem" value
    static member inline data (value: seq<'Item>) = Interop.mkAttr "data" value
    static member inline ItemSeparatorComponent (value: ReactElement) = Interop.mkAttr "ItemSeparatorComponent" value
    static member inline ListEmptyComponent (value: ReactElement) = Interop.mkAttr "ListEmptyComponent" value
    static member inline ListFooterComponent (value: ReactElement) = Interop.mkAttr "ListFooterComponent" value
    static member inline ListFooterComponentStyle (value: seq<IStyleAttribute>) = Interop.mkAttr "ListFooterComponentStyle" value
    static member inline ListHeaderComponent (value: ReactElement) = Interop.mkAttr "ListHeaderComponent" value
    static member inline ListHeaderComponentStyle (value: seq<IStyleAttribute>) = Interop.mkAttr "ListHeaderComponentStyle" value
    static member inline columnWrapperStyle (value: seq<IStyleAttribute>) = Interop.mkAttr "columnWrapperStyle" value
    static member inline extraData (value: _) = Interop.mkAttr "extraData" value
    static member inline getItemLayout (value: (obj * int) -> {| length: int; offset: int; index: int |}) = Interop.mkAttr "getItemLayout" value
    static member inline initialNumToRender (value: int) = Interop.mkAttr "initialNumToRender" value
    static member inline initialScrollIndex (value: float) = Interop.mkAttr "initialScrollIndex" value
    static member inline inverted (value: bool) = Interop.mkAttr "inverted" value
    static member inline keyExtractor (value: ('Item * int) -> string) = Interop.mkAttr "keyExtractor" value
    static member inline numColumns (value: int) = Interop.mkAttr "numColumns" value
    static member inline onEndReached (value: {| info: {| distanceFromEnd: int |} |} -> unit) = Interop.mkAttr "onEndReached" value
    static member inline onEndReachedThreshold (value: float) = Interop.mkAttr "onEndReachedThreshold" value
    static member inline onRefresh (value: unit -> unit) = Interop.mkAttr "onRefresh" value
    static member inline onViewableItemsChanged (value: {| callback: {| changed: ViewToken []; viewableItems: ViewToken [] |} |} -> unit) = Interop.mkAttr "onViewableItemsChanged" value
    static member inline progressViewOffset (value: float) = Interop.mkAttr "progressViewOffset" value
    static member inline refreshing (value: bool) = Interop.mkAttr "refreshing" value
    static member inline viewabilityConfig (value: seq<IViewabilityConfig>) = Interop.mkAttr "viewabilityConfig" (createObj !!value)
    static member inline viewabilityConfigCallbackPairs
        (value:
            (seq<IViewabilityConfig> *
            ({| info:
                   {| viewableItems: ViewToken []
                      changed: ViewToken [] |} |} -> unit)))
        =
        let config, callback = value

        createObj [
            "viewabilityConfig" ==> (createObj !!config)
            "onViewableItemsChanged" ==> callback
        ]
        |> Interop.mkAttr "viewabilityConfigCallbackPairs"

    // StatusBar
    static member inline animated (value: bool) = Interop.mkAttr "animated" value
    /// Only on Android.
    static member inline backgroundColor (value: string) = Interop.mkAttr "backgroundColor" value
    static member inline hidden (value: bool) = Interop.mkAttr "hidden" value
    /// Only on iOS.
    static member inline networkActivityIndicatorVisible (value: bool) = Interop.mkAttr "networkActivityIndicatorVisible" value
    static member inline translucent (value: bool) = Interop.mkAttr "translucent" value

    // Pressable
    /// Only on Android.
    static member inline androidDisableSound (value: bool) = Interop.mkAttr "android_disableSound" value
    /// Only on Android.
    static member inline androidRipple (value: seq<IRippleConfig>) = Interop.mkAttr "android_ripple" (createObj !!value)
    static member inline unstablePressDelay (value: float) = Interop.mkAttr "unstable_pressDelay" value
    static member inline delayLongPress (value: float) = Interop.mkAttr "delayLongPress" value
    static member inline testOnlyPressed (value: bool) = Interop.mkAttr "testOnly_pressed" value


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
    type autoCapitalize =
        static member inline none = Interop.mkAttr "autoCapitalize" "none"
        static member inline characters = Interop.mkAttr "autoCapitalize" "characters"
        static member inline words = Interop.mkAttr "autoCapitalize" "words"
        static member inline sentences = Interop.mkAttr "autoCapitalize" "sentences"
    [<Erase>]
    type autoComplete =
        static member inline birthdateDay = Interop.mkAttr "autoComplete" "birthdate-day"
        static member inline birthdateFull = Interop.mkAttr "autoComplete" "birthdate-full"
        static member inline birthdateMonth = Interop.mkAttr "autoComplete" "birthdate-month"
        static member inline birthdateYear = Interop.mkAttr "autoComplete" "birthdate-year"
        static member inline ccCsc = Interop.mkAttr "autoComplete" "cc-csc"
        static member inline ccExp = Interop.mkAttr "autoComplete" "cc-exp"
        static member inline ccExpDay = Interop.mkAttr "autoComplete" "cc-exp-day"
        static member inline ccExpMonth = Interop.mkAttr "autoComplete" "cc-exp-month"
        static member inline ccExpYear = Interop.mkAttr "autoComplete" "cc-exp-year"
        static member inline ccNumber = Interop.mkAttr "autoComplete" "cc-number"
        static member inline email = Interop.mkAttr "autoComplete" "email"
        static member inline gender = Interop.mkAttr "autoComplete" "gender"
        static member inline name = Interop.mkAttr "autoComplete" "name"
        static member inline nameFamily = Interop.mkAttr "autoComplete" "name-family"
        static member inline nameGiven = Interop.mkAttr "autoComplete" "name-given"
        static member inline nameMiddle = Interop.mkAttr "autoComplete" "name-middle"
        static member inline nameMiddleInitial = Interop.mkAttr "autoComplete" "name-middle-initial"
        static member inline namePrefix = Interop.mkAttr "autoComplete" "name-prefix"
        static member inline nameSuffix = Interop.mkAttr "autoComplete" "name-suffix"
        static member inline password = Interop.mkAttr "autoComplete" "password"
        static member inline passwordNew = Interop.mkAttr "autoComplete" "password-new"
        static member inline postalAddress = Interop.mkAttr "autoComplete" "postal-address"
        static member inline postalAddressCountry = Interop.mkAttr "autoComplete" "postal-address-country"
        static member inline postalAddressExtended = Interop.mkAttr "autoComplete" "postal-address-extended"
        static member inline postalAddressExtendedPostalCode = Interop.mkAttr "autoComplete" "postal-address-extended-postal-code"
        static member inline postalAddressLocality = Interop.mkAttr "autoComplete" "postal-address-locality"
        static member inline postalAddressRegion = Interop.mkAttr "autoComplete" "postal-address-region"
        static member inline postalCode = Interop.mkAttr "autoComplete" "postal-code"
        static member inline streetAddress = Interop.mkAttr "autoComplete" "street-address"
        static member inline smsOtp = Interop.mkAttr "autoComplete" "sms-otp"
        static member inline tel = Interop.mkAttr "autoComplete" "tel"
        static member inline telCountryCode = Interop.mkAttr "autoComplete" "tel-country-code"
        static member inline telNational = Interop.mkAttr "autoComplete" "tel-national"
        static member inline telDevice = Interop.mkAttr "autoComplete" "tel-device"
        static member inline username = Interop.mkAttr "autoComplete" "username"
        static member inline usernameNew = Interop.mkAttr "autoComplete" "username-new"
        static member inline off = Interop.mkAttr "autoComplete" "off"
    [<Erase>]
    type clearButtonMode =
        /// Only on iOS.
        static member inline never = Interop.mkAttr "clearButtonMode" "never"
        /// Only on iOS.
        static member inline whileEditing = Interop.mkAttr "clearButtonMode" "while-editing"
        /// Only on iOS.
        static member inline unlessEditing = Interop.mkAttr "clearButtonMode" "unless-editing"
        /// Only on iOS.
        static member inline always = Interop.mkAttr "clearButtonMode" "always"
    [<Erase>]
    type contentInsetAdjustmentBehavior =
        /// Only on iOS.
        static member inline automatic = Interop.mkAttr "contentInsetAdjustmentBehavior" "automatic"
        /// Only on iOS.
        static member inline scrollableAxes = Interop.mkAttr "contentInsetAdjustmentBehavior" "scrollableAxes"
        /// Only on iOS.
        static member inline never = Interop.mkAttr "contentInsetAdjustmentBehavior" "never"
        /// Only on iOS.
        static member inline always = Interop.mkAttr "contentInsetAdjustmentBehavior" "always"
    [<Erase>]
    type dataDetectorType =
        static member inline phoneNumber = Interop.mkAttr "dataDetectorType" "phoneNumber"
        static member inline link = Interop.mkAttr "dataDetectorType" "link"
        static member inline address = Interop.mkAttr "dataDetectorType" "address"
        static member inline calendarEvent = Interop.mkAttr "dataDetectorType" "calendarEvent"
        static member inline email = Interop.mkAttr "dataDetectorType" "email"
        static member inline none = Interop.mkAttr "dataDetectorType" "none"
        static member inline all = Interop.mkAttr "dataDetectorType" "all"
    [<Erase>]
    type decelerationRate =
        static member normal = Interop.mkAttr "decelerationRate" "normal"
        static member fast = Interop.mkAttr "decelerationRate" "fast"
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
    type importantForAutofill =
        static member inline auto = Interop.mkAttr "importantForAutofill" "auto"
        static member inline no = Interop.mkAttr "importantForAutofill" "no"
        static member inline noExcludeDescendants = Interop.mkAttr "importantForAutofill" "noExcludeDescendants"
        static member inline yes = Interop.mkAttr "importantForAutofill" "yes"
        static member inline yesExcludeDescendants = Interop.mkAttr "importantForAutofill" "yesExcludeDescendants"
    [<Erase>]
    type indicatorStyle =
        /// Only on iOS.
        static member inline default' = Interop.mkAttr "indicatorStyle" "default"
        /// Only on iOS.
        static member inline black = Interop.mkAttr "indicatorStyle" "black"
        /// Only on iOS.
        static member inline white = Interop.mkAttr "indicatorStyle" "white"
    [<Erase>]
    type keyboardAppearance =
        /// Only on iOS.
        static member inline default' = Interop.mkAttr "keyboardAppearance" "default"
        /// Only on iOS.
        static member inline light = Interop.mkAttr "keyboardAppearance" "light"
        /// Only on iOS.
        static member inline dark = Interop.mkAttr "keyboardAppearance" "dark"
    [<Erase>]
    type keyboardDismissMode =
        static member inline none = Interop.mkAttr "keyboardDismissMode" "none"
        static member inline noDrag = Interop.mkAttr "keyboardDismissMode" "no-drag"
        /// Only on iOS.
        static member inline interactive = Interop.mkAttr "keyboardDismissMode" "interactive"
    [<Erase>]
    type keyboardShouldPersistTaps =
        static member inline never = Interop.mkAttr "keyboardShouldPersistTaps" "never"
        static member inline always = Interop.mkAttr "keyboardShouldPersistTaps" "always"
        static member inline handled = Interop.mkAttr "keyboardShouldPersistTaps" "handled"
    [<Erase>]
    type keyboardType =
        static member inline default' = Interop.mkAttr "keyboardType" "default"
        static member inline numberPad = Interop.mkAttr "keyboardType" "number-pad"
        static member inline decimalPad = Interop.mkAttr "keyboardType" "decimal-pad"
        static member inline numeric = Interop.mkAttr "keyboardType" "numeric"
        static member inline emailAddress = Interop.mkAttr "keyboardType" "email-address"
        static member inline phonePad = Interop.mkAttr "keyboardType" "phone-pad"
        static member inline url = Interop.mkAttr "keyboardType" "url"

        /// Only on iOS.
        static member inline asciiCapable = Interop.mkAttr "keyboardType" "ascii-capable"
        /// Only on iOS.
        static member inline numbersAndPunctuation = Interop.mkAttr "keyboardType" "numbers-and-punctuation"
        /// Only on iOS.
        static member inline namePhonePad = Interop.mkAttr "keyboardType" "name-phone-pad"
        /// Only on iOS.
        static member inline twitter = Interop.mkAttr "keyboardType" "twitter"
        /// Only on iOS.
        static member inline webSearch = Interop.mkAttr "keyboardType" "web-search"

        /// Only on Android.
        static member inline visiblePassword = Interop.mkAttr "keyboardType" "visible-password"
    [<Erase>]
    type overScrollMode =
        /// Only on Android.
        static member inline auto = Interop.mkAttr "overScrollMode" "auto"
        /// Only on Android.
        static member inline always = Interop.mkAttr "overScrollMode" "always"
        /// Only on Android.
        static member inline never = Interop.mkAttr "overScrollMode" "never"
    [<Erase>]
    type pointerEvents =
        static member inline auto = Interop.mkAttr "pointerEvents" "auto"
        static member inline none = Interop.mkAttr "pointerEvents" "none"
        static member inline boxNone = Interop.mkAttr "pointerEvents" "box-none"
        static member inline boxOnly = Interop.mkAttr "pointerEvents" "box-only"
    [<Erase>]
    type resizeMethod =
        /// Only on Android.
        static member inline auto = Interop.mkAttr "resizeMethod" "auto"
        /// Only on Android.
        static member inline resize = Interop.mkAttr "resizeMethod" "resize"
        /// Only on Android.
        static member inline scale = Interop.mkAttr "resizeMethod" "scale"
    [<Erase>]
    type resizeMode =
        static member inline cover = Interop.mkStyle "resizeMode" "cover"
        static member inline contain = Interop.mkStyle "resizeMode" "contain"
        static member inline stretch = Interop.mkStyle "resizeMode" "stretch"
        static member inline repeat = Interop.mkStyle "resizeMode" "repeat"
        static member inline center = Interop.mkStyle "resizeMode" "center"
    [<Erase>]
    type returnKeyType =
        static member inline done' = Interop.mkAttr "returnKeyType" "done"
        static member inline go = Interop.mkAttr "returnKeyType" "go"
        static member inline next = Interop.mkAttr "returnKeyType" "next"
        static member inline search = Interop.mkAttr "returnKeyType" "search"
        static member inline send = Interop.mkAttr "returnKeyType" "send"

        /// Only on Android.
        static member inline none = Interop.mkAttr "returnKeyType" "none"
        /// Only on Android.
        static member inline previous = Interop.mkAttr "returnKeyType" "previous"

        /// Only on iOS.
        static member inline default' = Interop.mkAttr "returnKeyType" "default"
        /// Only on iOS.
        static member inline emergencyCall = Interop.mkAttr "returnKeyType" "emergency-call"
        /// Only on iOS.
        static member inline google = Interop.mkAttr "returnKeyType" "google"
        /// Only on iOS.
        static member inline join = Interop.mkAttr "returnKeyType" "join"
        /// Only on iOS.
        static member inline route = Interop.mkAttr "returnKeyType" "route"
        /// Only on iOS.
        static member inline yahoo = Interop.mkAttr "returnKeyType" "yahoo"
    [<Erase>]
    type snapToAlignment =
        /// Only on iOS.
        static member inline start = Interop.mkAttr "snapToAlignment" "start"
        /// Only on iOS.
        static member inline center = Interop.mkAttr "snapToAlignment" "center"
        /// Only on iOS.
        static member inline end' = Interop.mkAttr "snapToAlignment" "end"
    [<Erase>]
    type textAlign =
        static member inline left = Interop.mkAttr "textAlign" "left"
        static member inline center = Interop.mkAttr "textAlign" "center"
        static member inline right = Interop.mkAttr "textAlign" "right"
    [<Erase>]
    type textContentType =
        /// Only on iOS.
        static member inline none = Interop.mkAttr "textContentType" "none"
        /// Only on iOS.
        static member inline URL = Interop.mkAttr "textContentType" "URL"
        /// Only on iOS.
        static member inline addressCity = Interop.mkAttr "textContentType" "addressCity"
        /// Only on iOS.
        static member inline addressCityAndState = Interop.mkAttr "textContentType" "addressCityAndState"
        /// Only on iOS.
        static member inline addressState = Interop.mkAttr "textContentType" "addressState"
        /// Only on iOS.
        static member inline countryName = Interop.mkAttr "textContentType" "countryName"
        /// Only on iOS.
        static member inline creditCardNumber = Interop.mkAttr "textContentType" "creditCardNumber"
        /// Only on iOS.
        static member inline emailAddress = Interop.mkAttr "textContentType" "emailAddress"
        /// Only on iOS.
        static member inline familyName = Interop.mkAttr "textContentType" "familyName"
        /// Only on iOS.
        static member inline fullStreetAddress = Interop.mkAttr "textContentType" "fullStreetAddress"
        /// Only on iOS.
        static member inline givenName = Interop.mkAttr "textContentType" "givenName"
        /// Only on iOS.
        static member inline jobTitle = Interop.mkAttr "textContentType" "jobTitle"
        /// Only on iOS.
        static member inline location = Interop.mkAttr "textContentType" "location"
        /// Only on iOS.
        static member inline middleName = Interop.mkAttr "textContentType" "middleName"
        /// Only on iOS.
        static member inline name = Interop.mkAttr "textContentType" "name"
        /// Only on iOS.
        static member inline namePrefix = Interop.mkAttr "textContentType" "namePrefix"
        /// Only on iOS.
        static member inline nameSuffix = Interop.mkAttr "textContentType" "nameSuffix"
        /// Only on iOS.
        static member inline nickname = Interop.mkAttr "textContentType" "nickname"
        /// Only on iOS.
        static member inline organizationName = Interop.mkAttr "textContentType" "organizationName"
        /// Only on iOS.
        static member inline postalCode = Interop.mkAttr "textContentType" "postalCode"
        /// Only on iOS.
        static member inline streetAddressLine1 = Interop.mkAttr "textContentType" "streetAddressLine1"
        /// Only on iOS.
        static member inline streetAddressLine2 = Interop.mkAttr "textContentType" "streetAddressLine2"
        /// Only on iOS.
        static member inline sublocality = Interop.mkAttr "textContentType" "sublocality"
        /// Only on iOS.
        static member inline telephoneNumber = Interop.mkAttr "textContentType" "telephoneNumber"
        /// Only on iOS.
        static member inline username = Interop.mkAttr "textContentType" "username"
        /// Only on iOS.
        static member inline password = Interop.mkAttr "textContentType" "password"
        /// Only on iOS.
        static member inline newPassword = Interop.mkAttr "textContentType" "newPassword"
        /// Only on iOS.
        static member inline oneTimeCode = Interop.mkAttr "textContentType" "oneTimeCode"
    [<Erase>]
    type textBreakStrategy =
        /// Only on Android.
        static member inline simple = Interop.mkAttr "textBreakStrategy" "simple"
        /// Only on Android.
        static member inline hightQuality = Interop.mkAttr "textBreakStrategy" "hightQuality"
        /// Only on Android.
        static member inline balanced = Interop.mkAttr "textBreakStrategy" "balanced"
    [<Erase>]
    type statusBarStyle =
        static member inline default' = Interop.mkAttr "barStyle" "default"
        static member inline lightContent = Interop.mkAttr "barStyle" "light-content"
        static member inline darkContent = Interop.mkAttr "barStyle" "dark-content"
    [<Erase>]
    type showHideTransition =
        static member inline none = Interop.mkAttr "showHideTransition" "none"
        static member inline fade = Interop.mkAttr "showHideTransition" "fade"
        static member inline slide = Interop.mkAttr "showHideTransition" "slide"