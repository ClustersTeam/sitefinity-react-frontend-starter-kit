## Sitefinity file structure - please find below the file structure and naming convention that me keep.

### Source files
```
    MVC || ResourcePackages/ProjectName
        -- Views
            --- Navigation
                    Default.Navigation.cshtml
            --- ContactsFilter (React component widget view)
                    ContactsFilterView.cshtml
        -- Scripts
            --- Navigation
                designerview-simple.js
                ui-navigation.js
            --- ContactsFilter (React component scripts folder)
                ---- Components
                ---- Reducers (Reducers folder)
                ---- API (API folder)
                ContactsFilter.jsx (jsx src file)
        -- Styles
            --- Navigation (Default Sitefinity widget styling folder)
                _navigation-list.scss (src file)
                _navigation-burger.scss (src file)
                navigation.js (js file where you import your 'navigation.scss' file so webpack can compile it)
                navigation.scss (src file where you include all of the above scss files to compile together)
            --- ContactsFilter (React component styling folder)
                ---- common
                        _contacts-filter-common.scss
                ---- components
                        _contacts-list.scss
                        _contacts-profile.scss
                        _contacts-results.scss
                contacts-filter.js (js file where you import your 'contacts-filter.scss' file so webpack can compile it)
                contacts-filter.scss (src file where you include all of the above scss files to compile together)
        -- Assets
            --- Images
            --- Fonts
```
### Compiled files goes in the created by the build destination folder "Mvc_Bundle"
```
    Mvc_Bundle || ResourcePackages/ProjectName.Bundle
        -- Scripts
            --- Navigation
                ui-navigation.bundle.js
            --- ContactsFilter (React component scripts folder)
                ContactsFilter.bundle.js (compiled dist bundle)
        -- Styles
            --- Navigation (Default Sitefinity widget styling folder)
                navigation.css (compiled and minified dist file that you'll include in your widget/component)
            --- ContactsFilter (React component styling folder)
                contacts-filter.css (compiled and minified dist file that you'll include in your widget/component)
        -- Assets
            --- Images
            --- Fonts
```
