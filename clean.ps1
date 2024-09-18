$patterns = @(
  ".vs",
  "bin",
  "obj"
)

$folders = Get-ChildItem -Path $rootPath -Recurse -Directory -Force -Include $patterns

foreach ( $folder in $folders )
{
  try {
    Remove-Item -Force -Recurse -Path $folder
    Write-Host "Removed: $folder"
  }
  catch {
    Write-Error "REMOVE FAILED: $folder"
  }
}
