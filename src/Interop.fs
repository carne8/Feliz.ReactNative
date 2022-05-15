namespace Feliz.ReactNative

open Feliz
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Interop =
    let nativeReactElement (_element: obj) (_props: 'a): ReactElement = import "createElement" "react"

    let inline reactNativeElementWithChild (name: string) (child: 'a) =
        nativeReactElement (import name "react-native") (createObj [ "children" ==> ResizeArray [| child |] ])
    let inline reactNativeElementWithChildren (name: string) (children: seq<ReactElement>) =
        nativeReactElement (import name "react-native") (createObj [ "children" ==> Interop.reactApi.Children.toArray (Array.ofSeq children) ])
    let inline createNativeElement (name: string) (properties: IReactProperty list) : ReactElement =
        nativeReactElement (import name "react-native") (createObj !!properties)