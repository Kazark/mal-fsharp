[<EntryPoint>]
let rec main args =
    let mode = REPL.getReadlineMode args
    let args = Seq.ofArray args |> Seq.filter (fun e -> e <> "--raw") |> List.ofSeq
    let env = REPL.configureEnv args mode

    match args with
    | file::_ ->
        System.IO.File.ReadAllText file
        |> REPL.RE env |> Seq.iter ignore
        0
    | _ ->
        stdout.WriteLine Printer.welcome
        stdout.WriteLine Printer.asciiArt
        let rec loop () =
            match Readline.read "mal> " mode with
            | null -> 0
            | input ->
                REPL.REP env input
                loop ()
        loop ()
