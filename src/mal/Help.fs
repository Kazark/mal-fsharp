module Help

let message = """
Core Language:
    Integers - e.g. 42
    Atoms - e.g. :lisprocks
    Strings - e.g. "Hello world"
    Lists - e.g. [1 2 3] or [1, 2, 3]
    Functions - e.g. +
    Function applications - e.g. (+ 1 2)

Functions:
    Arithmetic:
        mal> (+ 3 4)
        7
        mal> (- 3 4)
        -1
        mal> (/ 3 4)
        0
        mal> (* 3 4)
        12
    Comparison:
        mal> (= 3 4)
        false
        mal> (> 3 4)
        false
        mal> (< 3 4)
        true

REPL Commands:
    Use ;quit or ;q or ;exit to quit the REPL.
    Use ;help or ;h or ;? to show this message.
    
If this message did not provide the help you needed, feel free to improve it."""
