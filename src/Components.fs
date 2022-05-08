namespace Feliz.ReactNative

open Feliz
open Fable.Core
open Fable.React

[<Erase>]
type Comp =
    static member inline view props = Interop.createNativeElement "View" props
    static member inline view (children: seq<ReactElement>) = Interop.reactNativeElementWithChildren "View" children

    static member inline text props = Interop.createNativeElement "Text" props
    static member inline text (text: string) = Interop.reactNativeElementWithChild "Text" text

    static member inline textInput props = Interop.createNativeElement "TextInput" props

    static member inline image props = Interop.createNativeElement "Image" props
    static member inline image (imageSource: IImageSource) = Interop.createNativeElement "Image" [ prop.source imageSource ]
    static member inline image (imageSource: seq<IImageSourceProp>) = Interop.createNativeElement "Image" [ prop.source imageSource ]