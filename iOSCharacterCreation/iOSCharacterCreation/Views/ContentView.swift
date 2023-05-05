//
//  ContentView.swift
//  iOSCharacterCreation
//
//  Created by Angelika Shaiko on 5.05.23.
//

import SwiftUI

struct ContentView: View {
    var body: some View {
        NavigationView {
            VStack {
                NavigationLink(destination: CharacterDataView()) {
                    Text("Enter the data for the character")
                }
            }
        }
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
