# Define the root directory for the solution
$rootDir = "."

# Define the list of folders to create
$folders = @(
    "Advance Concepts",
    "APIs",
    "Best Practices",
    "Data Access",
    "Fundamentals",
    "Globalization and Localization",
    "Performance",
    "Realtime Apps",
    "Remote Procedure Call Apps",
    "Security",
    "Servers",
    "Testing",
    "Web Apps"
)

# Create each folder under the root directory
foreach ($folder in $folders) {
    $folderPath = Join-Path -Path $rootDir -ChildPath $folder
    if (-Not (Test-Path -Path $folderPath)) {
        New-Item -ItemType Directory -Path $folderPath
    }
}