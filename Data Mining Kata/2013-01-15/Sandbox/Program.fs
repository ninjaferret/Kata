// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let test a b  = a * b

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "%A" (test 3 4)
    0 // return an integer exit code




