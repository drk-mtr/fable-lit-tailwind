module Lit.TodoMVC.MyOtherComponent

open Lit
open Fable.Core
open Fable.Core.JsInterop

let register() = ()

[<Emit("import tailwindStyles from '/src/out/style.css'")>]
let importTailwindStyles() = jsNative

importTailwindStyles()

[<Emit("tailwindStyles")>]
let tailwindStyles: string = jsNative

[<Emit("new CSSStyleSheet()")>]
let newCSSStyleSheet() = jsNative

[<LitElement("my-other-component")>]
let MyOtherComponent() =
    let _ = LitElement.init(fun init ->
        init.useShadowDom <- true
    )

    let style = newCSSStyleSheet()
    style?replace(tailwindStyles)
    jsThis?shadowRoot?adoptedStyleSheets <- [| style |]

    html $"""
        <div class="bg-indigo-100 text-black rounded border-2 border-teal-600 mb-2">
            My Other Component
        </div>
    """