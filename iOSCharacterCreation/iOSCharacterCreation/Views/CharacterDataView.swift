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
    @State private var gender: Gender = .male
    @State private var age: String = "0"
    
    var body: some View {
        VStack {
            TextField("Name", text: $name)
                .textFieldStyle(RoundedBorderTextFieldStyle())
                .padding()
            
            TextField("Age", text: $age)
                .textFieldStyle(RoundedBorderTextFieldStyle())
                .keyboardType(.numberPad)
                .onReceive(age.publisher.collect()) { newValue in
                    let filtered = newValue.filter { $0.isNumber }
                    self.age = String(filtered.prefix(3))
                }
                .padding()
            
            Picker(selection: $gender, label: Text("Gender")) {
                ForEach(Gender.allCases, id: \.self) { gender in
                    Text(gender.rawValue)
                }
            }
            .pickerStyle(SegmentedPickerStyle())
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
            methodName: "SetAge",
            message: age
        )
        Unity.shared.sendMessage(
            ObjectName,
            methodName: "SetName",
            message: name
        )
        Unity.shared.sendMessage(
            ObjectName,
            methodName: "SetGender",
            message: gender.rawValue
        )
    }
}

struct CharacterDataView_Previews: PreviewProvider {
    static var previews: some View {
        CharacterDataView()
    }
}
