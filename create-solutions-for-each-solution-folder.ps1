# Define the root directory for the solution
$rootDir = "."

# Get all sub-folders under the root directory
$subFolders = Get-ChildItem -Path $rootDir -Directory

# Create a solution file for each sub-folder
foreach ($folder in $subFolders) {
    $solutionFileName = "$($folder.FullName)\$($folder.Name).sln"
    dotnet new sln -n $folder.Name -o $folder.FullName
}