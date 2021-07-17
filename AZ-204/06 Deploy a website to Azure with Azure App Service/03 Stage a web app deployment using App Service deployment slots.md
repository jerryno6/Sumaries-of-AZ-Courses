# Create deployment slots
- a single Azure App Service web app, you can create multiple deployment slots
- Each slot is a separate instance of that web app, and it has a separate hostname

# Exercise - Create deployment slots

# Deploy a web app by swapping deployment slots
- When you swap two slots, the app's configuration travels to the new slot along with the app
- Create slot settings for the setting of applicaiton in each environment
- slot-swapping preview: 
    - Phase 1: apply target settings to source settings
    - Phase 2: then swap host name
- Autoswap: for continuous deployment. Azure automatically swaps it whenever you push code or content into that slot.
- Swap again for rolling back

# Exercise - Deploy a web app by using deployment slots