/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package k_electric;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;

/**
 *
 * @author Ali Hassan
 */
public class K_electric extends Application {
    
    @Override
    public void start(Stage primaryStage) {
        
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Input_Form obj=new Input_Form();
        obj.show();
    }
    
}
