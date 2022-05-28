module Lit.TodoMVC.App

open Lit

MyComponent.register()
MyOtherComponent.register()

[<LitElement("my-app")>]
let MyApp() =
    let _ = LitElement.init(fun cfg ->
        cfg.useShadowDom <- false
    )

    html $"""
        <my-component></my-component>
        <my-other-component></my-other-component>
        <div class="custom-class-bg-blue rounded-lg">whatever</div>
    """
