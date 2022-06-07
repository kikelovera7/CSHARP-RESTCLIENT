//WE ARE GOING TO PERFORM SOME APIS GET CALL AND DO SOME DATA PROCESSING. USING .NET6 NEW VERSION.
using RequestTask;




var repositories= await RequestMethod.ProcessRepositories();

foreach (var repo in repositories){
    Console.WriteLine(repo.Name);
    Console.WriteLine(repo.Description);
    Console.WriteLine(repo.GitHubHomeUrl);
    Console.WriteLine(repo.Homepage);
    Console.WriteLine(repo.Watchers);
    Console.WriteLine();
}




