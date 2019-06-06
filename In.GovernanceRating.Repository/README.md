# Refactoring notes

### We need to seperate the Repository contracts to a seperate file in future.  
Project structure could be:
**DataAccess**
 -- In.GovernanceRating.Repository
    [This will contain the dbContexts and the Repository implementations]
 -- In.GovernanceRating.Repository.Contract
    [This will contain interfaces]


### Analysis needed in future for number of repository classes
We could have one repository for multiple related entities. This would reduce the clutter. Too much seperation of concern can cause a lot of clutter.

### Contexts should be 1 for simple scenarios. For better DDD seggregation multiple contexts may be needed.
Some entities like User has application wide usage. We put those entities in ApplicationContext.
Other entities which are bound by some domain will be kept in their domain context. For example MunicipalCorporation entity falls under MunicipalCorporationRatingContext.


