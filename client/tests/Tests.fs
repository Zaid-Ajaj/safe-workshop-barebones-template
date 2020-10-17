module Tests

open Fable.Mocha
open App

let add x y = x + y

let appTests = testList "App tests" [

    testCase "Addtion works" <| fun _ -> 
        let expected = 5
        let actual = add 2 3
        Expect.equal actual expected "Addition should work"
]

let allTests = testList "All" [
    appTests
]

[<EntryPoint>]
let main (args: string[]) = Mocha.runTests allTests