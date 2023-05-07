//
//  CharacterDataView.swift
//  iOSCharacterCreation
//
//  Created by Angelika Shaiko on 5.05.23.
//

import SwiftUI

struct CharacterDataView: View {
    var body: some View {
        VStack {
            Button(action: {
                Unity.shared.show()
            }) {
                Text("Generate character")
            }
        }
    }
}

struct CharacterDataView_Previews: PreviewProvider {
    static var previews: some View {
        CharacterDataView()
    }
}
