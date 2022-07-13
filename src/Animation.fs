module Feliz.ReactNative.Animation

open Fable.Core
open Fable.Core.JsInterop
open Feliz.ReactNative

type AnimationValue = float
type AnimationFunc =
    abstract member start: unit -> unit
    abstract member start: callback: (obj -> unit) -> unit

type TimingOptions =
    { toValue: float
      duration: int
      useNativeDriver: bool }

type SpringOptions =
    { toValue: float
      speed: int
      bounciness: int
      useNativeDriver: bool }

[<Erase>]
type Animated =
    [<Emit "new $0.Value($1)">]
    abstract member Value: float -> AnimationValue
    abstract member divide: float -> AnimationValue -> AnimationValue
    abstract member spring: AnimationValue -> SpringOptions -> AnimationFunc
    abstract member timing: AnimationValue -> TimingOptions -> AnimationFunc

let Anim: Animated =
    import "Animated" "react-native"


[<Erase>]
type Comp =
    static member inline viewAnimated = Interop.createNativeElement "Animated.View"
    static member inline imageAnimated = Interop.createNativeElement "Animated.Image"
    static member inline textAnimated = Interop.createNativeElement "Animated.text"
    static member inline scrollViewAnimated = Interop.createNativeElement "Animated.ScrollView"
    static member inline flatListAnimated = Interop.createNativeElement "Animated.FlatList"
    static member inline sectionListAnimated = Interop.createNativeElement "Animated.SectionList"