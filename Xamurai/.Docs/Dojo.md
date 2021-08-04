# Dojo Challenge #1

**Paged Collection View**

## Instructions

Implement a collection view for a collection of cars (see some of the Experiments pages). The layout should preferably look like the FlexLayoutPage example, but swiping behavior similar to a Carousel Page where you swipe 2 columns at a time, or like the CollectionView GridLayout example where it snaps into place.

- Use the /Challenges/PagedCollectionPage.xaml for your implementation
- Implement carousel paging for a 2-column page, but where each element stacks like in the FlexLayoutPage example
- Use the CarView as the item template
- No rules for how you achieve this (there is no one correct way to do this)

For Example, you can choose to use a Carousel View that contains flex layouts by splitting the collection,	or by implementing a snap behavior for a flex layout that scrolls to the next 2 columns on swipe.

- Target iOS or Android as a primary platform
- Feel free to add / remove / upgrade / downgrade nuget packages to help you with your task
- Recommendation is not to spend more than 4 - 5 hours on this task. If incomplete, just add some notes as to your intent for what you did do.

#### Stretch Goals

- The implementation should cater for template resizing (tap the circle to collapse the template)
- Implement in Android or iOS as well
