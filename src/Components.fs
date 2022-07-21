namespace Feliz.ReactNative

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<Erase>]
type Comp =
    static member inline fragment (children: seq<ReactElement>) = Interop.createElement (import "Fragment" "react") (createObj [ "children", children ])
    static member inline keyedFragment (key: string) (children: seq<ReactElement>) = Interop.createElement (import "Fragment" "react") (createObj [ "key", key; "children", children ])

    static member inline view props = Interop.createElementFromName "View" props
    static member inline view (children: seq<ReactElement>) = Interop.createElementFromNameWithChildren "View" children

    static member inline text props = Interop.createElementFromName "Text" props
    static member inline text (text: string) = Interop.createElementFromName "Text" [ prop.text text ]

    static member inline textInput props = Interop.createElementFromName "TextInput" props

    static member inline image props = Interop.createElementFromName "Image" props
    static member inline image (imageSource: IImageSource) = Interop.createElementFromName "Image" [ prop.source imageSource ]
    static member inline image (imageSource: seq<IImageSourceProp>) = Interop.createElementFromName "Image" [ prop.source imageSource ]

    static member inline scrollView props = Interop.createElementFromName "ScrollView" props
    static member inline scrollView (child: ReactElement) = Interop.createElementFromNameWithChildren "ScrollView" [| child |]
    static member inline scrollView (children: seq<ReactElement>) = Interop.createElementFromNameWithChildren "ScrollView" children

    static member inline flatList props = Interop.createElementFromName "FlatList" props
    static member inline flatList (child: ReactElement) = Interop.createElementFromNameWithChildren "FlatList" [| child |]
    static member inline flatList (children: seq<ReactElement>) = Interop.createElementFromNameWithChildren "FlatList" children

    static member inline statusBar props = Interop.createElementFromName "StatusBar" props

    static member inline pressable props = Interop.createElementFromName "Pressable" props