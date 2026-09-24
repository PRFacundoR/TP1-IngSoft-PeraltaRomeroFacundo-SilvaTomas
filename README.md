# TP1-IngSoft-PeraltaRomeroFacundo-SilvaTomas


PARA EJECUTAR LOS TEST

# PASO 1

AQUI EJECUTAMOS LOS TEST Y LOS RESULTADOS SE GUARDAN EN LA CARPETA TESTRESULTS

dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.IncludeTestAssembly=true


# PASO 1.1

PARA EJECUTAR UN ARCHIVO ESPECIFICO USAR EL COMANDO

dotnet test --filter "FullyQualifiedName~namespace.class"




# PASO 2

AQUI EJECUTAMOS LA HERRAMIENTA "reportgenerator" QUE UTILIZA LOS RESULTADOS Y LOS MUESTRA EN LOS ARCHIVOS HTML DE FORMA LIMPIA

reportgenerator "-reports:TestResults/**/coverage.cobertura.xml" "-targetdir:CoverageReport" "-reporttypes:Html;TextSummary"


