# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions，解决方案的文件夹
$solutions = (
    ""
)

# List of projects
$projects = (

    # aspnet-core
    "src/Abp.Module.Basket.Application",
    "src/Abp.Module.Basket.Application.Contracts",
    "src/Abp.Module.Basket.Domain",
    "src/Abp.Module.Basket.Domain.Shared",
    "src/Abp.Module.Basket.EntityFrameworkCore",
    "src/Abp.Module.Basket.HttpApi",
    "src/Abp.Module.Basket.HttpApi.Client",
    "src/Abp.Module.Basket.MongoDB"
)