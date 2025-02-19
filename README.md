## Beskrivelse
Dette projekt implementerer Strategy Pattern for at udføre forskellige transformationer på en liste af heltal.

### Strategy Pattern
Strategy Pattern bruges til at definere en familie af algoritmer, sætte dem ind i et klassehierarki og gøre dem udskiftelige. I dette projekt bruges `IStrategy` interfacet og dets konkrete klasser (`StrategyMinus`, `StrategyPlus`, `StrategyMultiply`, `StrategyDivide`, `StrategySquare`) til at behandle dataene på forskellige måder. `DataProcesser` klassen bruger en instans af `IStrategy` til at udføre den valgte databehandlingsstrategi.

Derudover anvendes Strategy Pattern også til transformationer gennem `ITransformation` interfacet og dets konkrete klasser (`ListTransformation`, `MaxTransformation`, `MinOfTransformations`, `SumTransformation`). Disse transformationsklasser kan anvendes på dataene for at tilføje forskellige transformationer.

## Transformationer
- **SumTransformation**: Returnerer summen af data efter transformation.
- **ListTransformation**: Returnerer en liste af data efter transformation.
- **MinOfTransformations**: Returnerer det mindste af tallene efter transformation.
- **MaxTransformation**: Returnerer det største af tallene efter transformation.

## Brug
Eksempel på brug af DataProcessor med forskellige transformationer: