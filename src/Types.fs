namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JsInterop

type LayoutEvent =
    { layout: {| width: float; height: float; x: float; y: float |}
      target: float }

type PressEvent =
    { changedTouches: PressEvent []
      identifier: float
      locationX: float
      locationY: float
      pageX: float
      pageY: float
      target: float
      timestamp: float
      touches: PressEvent [] }

[<StringEnum; RequireQualifiedAccess>]
type AccessibilityRole =
    | Adjustable
    | Alert
    | Button
    | Checkbox
    | Combobox
    | Header
    | Image
    | Imagebutton
    | Keyboardkey
    | Link
    | Menu
    | Menubar
    | Menuitem
    | None
    | Progressbar
    | Radio
    | Radiogroup
    | Scrollbar
    | Search
    | Spinbutton
    | Summary
    | Switch
    | Tab
    | Tablist
    | Text
    | Timer
    | Togglebutton
    | Toolbar

type AccessibilityActions =
    { name: string
      label: string option }

type TextLayout =
    { capHeight: float
      ascender: float
      descender: float
      width: float
      height: float
      xHeight: float
      x: float
      y: float }

type TextLayoutEvent =
    { lines: TextLayout []
      target: float }

type Rect =
    { bottom: float
      left: float
      right: float
      top: float }

type ImageLoadEvent =
    { source:
        {| uri: string
           width: float
           height: float |} }

type IImageSource = interface end
type IImageSourceProp = interface end
type IImageCacheEnum = interface end

module ImageSource =
    [<Erase>]
    type cache =
        static member inline default' = unbox<IImageCacheEnum> "default"
        static member inline reload = unbox<IImageCacheEnum> "reload"
        static member inline forceCache = unbox<IImageCacheEnum> "force-cache"
        static member inline onlyIfCached = unbox<IImageCacheEnum> "only-if-cached"

    [<Erase>]
    type prop =
        static member inline uri (value: string) = unbox<IImageSourceProp> ("uri", value)
        static member inline width (value: float) = unbox<IImageSourceProp> ("width", value)
        static member inline height (value: float) = unbox<IImageSourceProp> ("height", value)
        static member inline scale (value: float) = unbox<IImageSourceProp> ("scale", value)
        /// Only on iOS.
        static member inline bundle (value: float) = unbox<IImageSourceProp> ("bundle", value)
        static member inline method (value: string) = unbox<IImageSourceProp> ("method", value)
        static member inline headers (value: obj) = unbox<IImageSourceProp> ("headers", value)
        static member inline body (value: string) = unbox<IImageSourceProp> ("body", value)
        static member inline cache (value: IImageCacheEnum) = unbox<IImageSourceProp> ("cache", value)

[<Erase>]
type ImageSource =
    static member inline local (path: string) = unbox<IImageSource> (importDefault path)