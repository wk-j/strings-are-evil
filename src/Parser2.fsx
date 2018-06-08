#load "ValueHolder.fsx"

open ValueHolder

open System.IO

let viaStreamReader(file: string) =
    use reader = File.OpenText file
    while reader.EndOfStream |> not do
        let line = reader.ReadLine()
        let parts = line.Split ','
        if parts.[0] = "MNO" then
            ValueHolder.FromArray(parts) |> ignore

#time
viaStreamReader "release/example-input.txt"
#time