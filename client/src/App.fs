module App

open Feliz
open Elmish
open Shared

type State = { name: string }

type Msg =
    | DoNothing

let init() = { name = "World" }, Cmd.none

let update (msg: Msg) (state: State) = state, Cmd.none

let render (state: State) (dispatch: Msg -> unit) =
    Html.div [
        Html.h1 ("Hello " + state.name)
        Html.p "This is a very simple UI"
    ]
