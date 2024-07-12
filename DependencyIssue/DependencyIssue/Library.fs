namespace DependencyIssue

module Say =
    let start () =
      Referenced.Say.hello "world"
