//
//  ViewController.swift
//  iOSCharacterCreation
//
//  Created by Angelika Shaiko on 5.05.23.
//

import UIKit
import SwiftUI

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        
        let vc = UIHostingController(rootView: ContentView())
        addChild(vc)
        vc.view.frame = self.view.frame
        view.addSubview(vc.view)
        vc.didMove(toParent: self)
    }
}

