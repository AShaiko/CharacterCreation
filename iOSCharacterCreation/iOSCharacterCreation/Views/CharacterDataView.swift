//
//  CharacterDataView.swift
//  iOSCharacterCreation
//
//  Created by Angelika Shaiko on 5.05.23.
//

import SwiftUI

fileprivate let ObjectName = "Character"

struct CharacterDataView: View {
    @State private var name: String = ""
    @State private var gender: String = ""
    @State private var age: Int = 0
    
    var body: some View {
        VStack {
            TextField("Name", text: $name)
                .textFieldStyle(RoundedBorderTextFieldStyle())
                .padding()
            
            TextField("Gender", text: $gender)
                .textFieldStyle(RoundedBorderTextFieldStyle())
                .padding()
            
            Stepper(value: $age, in: 0...100, step: 1) {
                Text("Age: \(age)")
            }
            .padding()
            
            Button(action: {
                Unity.shared.show()
                self.sendData()
            }) {
                Text("Generate character")
            }
        }
    }
    
    private func sendData() {
        Unity.shared.sendMessage(
            ObjectName,
            methodName: "SetName",
            message: name
        )
        Unity.shared.sendMessage(
            ObjectName,
            methodName: "SetGender",
            message: gender
        )
        Unity.shared.sendMessage(
            ObjectName,
            methodName: "SetAge",
            message: String(age)
        )
    }
}

struct CharacterDataView_Previews: PreviewProvider {
    static var previews: some View {
        CharacterDataView()
    }
}
