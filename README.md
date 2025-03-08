# StockForThePeople

The goal of this application is to allow casual investors to analyze the progress of their portfolio.
Ever notice how you can't really track how well one asset is doing compared to another? That's on purpose.
Analytical tools for small investors are usually hidden behind subscriptions.

This application attempts to give some of those insights without requiring a subscription fee.
Of course this comes with a downside. There are no minute to minute updates.
But if you are like me, you don't need that. What you need is a daily insight or even a weekly insight.

Questions like: 
- "Hey, the financial sector is up in the last month, but energy transition is down. Is that a common pattern?"
- "Hmm, last year food prices went down in september, maybe I should sell a bit of that in july?"
- "Which stock did better over the last 3 months compared to the others in my portfolio?"




Done:
- Set up several projects to separate concerns from the get go.
- Set up serilog
- First version of domain models and external DTOs
- ExternalData service receives and processes data
- Set up first database from EF core
- Use both postman and insomnia for testing

Next:
- Store first data


Patterns:
- options pattern
- service pattern
- 