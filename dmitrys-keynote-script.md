# Introduction

Thanks Scott, and hello folks! 

I am excited to have an opportunity to show you some of our newest XAML tooling features.

Today’s demos are focused on WPF and .NET 5, but just know that in most cases these features will work for any XAML app framework including WinUI, UWP and Xamarin.Forms. 

# DEMO #1 - XAML Data binding failure

Alright let’s get going 😊

First, we’ll start with a sample app designed to demonstrate our brand new XAML data binding failure experiences and it works for all .NET XAML app combinations, but it does work best if used with .NET 5. 

Let’s go look at the demo so I can show you what I mean.

## DEMO: DATA BINDING FAILURES

* Start with Output window (show ‘debug’ output)
* In-app toolbar binding failure icon
    * Click it >
* LVT - icon there too
* XAML Binding Failures panel
    * Previously only available in output window
    * Searchable - show
    * Rich right-click menu for customizing
        * Grouping, columns
* Navigate to source: and in .NET 5 – click to navigate to source!
        * First platform

# DEMO #2 - Design-time data

Let’s now go to our second demo.

This app demonstrates our new design-time data using d:, the concept that was originally added for Xamarin.Forms, and we’ve now made it available for more types of application scenarios such as WPF targeting .NET 5. 

Let’s jump into code.

## Demo: design-time data

Show empty app:

* Run the app, show its empty
    * Feels really at a certain stage of development

Features:

* Talk through first tab
* Look at how RichTextBox vs. TextBox is populated
* Go through all the tabs
* Open the List tax and show how the lists and datagrid were mocked

**Closing**

Now you might be thinking, didn’t we already have design-time data capability before d:? 

Yes, and you can still use the alternative approach of creating a mock ViewModel. But we created this new feature because its independent of your design-pattern choices and we think it’s easier to get started, so I hope you give it a try.

# BabySmash

Alright we’re two features down.

Now let’s tie all this together and go through our final two demos by switching to the BabySmash app.

This app originally had very few XAML pages and didn’t use MVVM. So, for my demos I decided to add a Splash Screen with everything that I needed.

But wait you might be wondering, what is MVVM? MVVM is Model-View-ViewModel, a design pattern that has become one of the most common ways people build WPF and other XAML applications, and there are even multiple open sources libraries that can help you too.

Lets jump into

**MVVM Changes to BabySmash**

* Talk about Folders: ViewModel, View, Entities

Design-time data in “real” scenario:

* Remove the two “d:” design-time data
    * This would have been much worse of an experience without the design-time data

## MVVM Features

Next like many real-world MVVM apps my DataContext is going to be set in code-behind or yours might be through a ViewModelLocator.

So, we’ve been working on improving IntelliSense support including helpful lightbulbs and more to make this experience better within the XAML code editor, let me show you what I mean.

* Add IntelliSense, show top
* Go to definition/peek
* Add a new property or command

## XAML Hot Reload

XAML Hot Reload lets you edit your XAML while your app is running with very few restrictions, it works for all XAML platforms as of 16.9, as starting with 16.9 we’re happy to announce that Xamarin.Forms is now fully supported.

So how does it help here?

* Make app top most
* Change Window
* Start changing properties
* Duplicate something
* Change the image size as it’s rotating

**Goodbye**

That’s all for my demos, have a great .NET Conf

Back to you Scott.
