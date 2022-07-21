namespace Feliz.ReactNative.Animation.Types

type AnimValue = float
type AnimEvent = interface end
type AnimFunc =
    abstract member start: unit -> unit
    abstract member start: callback: (obj -> unit) -> unit
    abstract member stop: unit -> unit
    abstract member reset: unit -> unit

type IEasing = interface end
type IConfigProp = interface end
type IComposeProp = interface end
type IInterpolateProp = interface end