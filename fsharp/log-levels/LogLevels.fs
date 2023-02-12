module LogLevels

let message (logLine: string): string = 
    let messageStart = logLine.IndexOf(':') + 1
    logLine[messageStart..].Trim()

let logLevel(logLine: string): string = 
    let starExpr = logLine.IndexOf('[') + 1
    let endExpr = logLine.IndexOf(']') - 1
    logLine[starExpr .. endExpr].ToLower()

let reformat(logLine: string): string = 
    $"{message logLine} ({logLevel logLine})"
