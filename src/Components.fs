namespace Feliz.ReactNative

open Feliz
open Fable.Core
open Fable.React

[<Erase>]
type Comp =
    static member inline fragment xs = React.fragment xs
    static member inline keyedFragment (key: int, xs) = React.keyedFragment(key, xs)

    static member inline view props = Interop.createNativeElement "View" props
    static member inline view (children: seq<ReactElement>) = Interop.reactNativeElementWithChildren "View" children

    static member inline text props = Interop.createNativeElement "Text" props
    static member inline text (text: string) = Interop.createNativeElement "Text" [ prop.text text ]

    static member inline textInput props = Interop.createNativeElement "TextInput" props

    static member inline image props = Interop.createNativeElement "Image" props
    static member inline image (imageSource: IImageSource) = Interop.createNativeElement "Image" [ prop.source imageSource ]
    static member inline image (imageSource: seq<IImageSourceProp>) = Interop.createNativeElement "Image" [ prop.source imageSource ]

    static member inline scrollView props = Interop.createNativeElement "ScrollView" props
    static member inline scrollView (child: ReactElement) = Interop.reactNativeElementWithChild "ScrollView" child
    static member inline scrollView (children: seq<ReactElement>) = Interop.reactNativeElementWithChildren "ScrollView" children

    static member inline flatList props = Interop.createNativeElement "FlatList" props
    static member inline flatList (child: ReactElement) = Interop.reactNativeElementWithChild "FlatList" child
    static member inline flatList (children: seq<ReactElement>) = Interop.reactNativeElementWithChildren "FlatList" children

    static member inline statusBar props = Interop.createNativeElement "StatusBar" props

    static member inline pressable props = Interop.createNativeElement "Pressable" props