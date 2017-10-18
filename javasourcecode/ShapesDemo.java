/*Demo of text fields, a label,   and drawing of triangles
 Create two triangles for manipulation one for drawing
*/
package code;
/*
 import library packages
 */

import javafx.scene.control.Button;
import javafx.scene.layout.Pane;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.application.Application;
//actions items
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
/** color class*/
import javafx.scene.paint.Color;
import javafx.scene.text.*;
/**
 *
 * @author Kyle Maloney
 */

public class ShapesDemo extends Application {
       /** create layouts refences */
       // buttons and Panes
    
    Pane authorPane,problemPane,trianglePane;
    Button authorButton,problemButton,triangleButton;
//basic setup containers
    Pane rootPane = new Pane();
    Scene scene;
    Stage stage;

    
    
	  Text t1,t2,t3,t4,t5,t6,t7;
	  public Pane createFrontPage()
      {
        Pane pane= new Pane();
        t2 = new Text(10, 80, "This is a test");
        t2.setFont(new Font(20));
        t2.setFill(Color.RED);
        t2.setWrappingWidth(500);
        t2.setTextAlignment(TextAlignment.CENTER);
        t2.setText("Demonstration of Assignment for\nJava, GUI and Visualization: CS5405");
        
        t3 = new Text(10, 120, "\nPresented by\n\nKyle Maloney, \n\nkemvy4@mst.edu\n");
        t3.setFont(new Font(20));
        t3.setFill(Color.GREEN);
        t3.setWrappingWidth(500);
        t3.setTextAlignment(TextAlignment.CENTER);
        
        t4 = new Text(10, 260, "\nThis is my orignal code, No IDE used in the submission. \nI did not give my code to anyone or I did not use anyone's code in this work. ");
        t4.setFont(new Font(20));
        t4.setFill(Color.BLUE);
        t4.setWrappingWidth(600);
        t4.setTextAlignment(TextAlignment.CENTER);
       
       //
        pane.getChildren().addAll(t2,t3,t4);
        pane.setLayoutX(10);pane.setLayoutY(50);
        return pane;
      }
	  
      
      public Pane createProblemPage()
      {
        Pane pane = new Pane();
        t7 = new Text(10, 40,
                      "  This is extension of HW08. Use mouse to input triangles interactively on the screen. As the mouse moves it tells you the x-y coordinates of the point under the cursor. You can see the coordinates before clicking it. When you click mouse, you can record x, y coordinates of the point. You can control the program with button for new set of triangles. Read that assignment in addition As in HW06, you used textField to read input, input  two triangles: x1 y1 w1 h1 x2  y2 w2 h2  (pixels are integers) ( x1 y1 w1,h1 means that triangle vertices are (x1,y1),(x1+w1,y1),  (x1+w1/2,y1+h1)).  You will need polygon class to draw the triangle. If you decide to use any other means of input for triangle. Describe it in a prompt label above the textField ) . Output on a label to describe what kind of intersection takes place: interiors disjoint (DC- disconnected), interiors disjoint and touching externally (EC- externally connected), proper overlap PO), equal (EQ), NTPP and TPP are distinguished as TPP (Triangle 1 is inside triangle2 and touches the boundary of triangle 2, where as NTPP (Triangle 1 is inside triangle2 and does not touch the boundary of triangle 2,conversely NTPPc and TPPc are distinguished as TPPc (Triangle 2 is inside triangle1 and touches the boundary of triangle 1, where as NTPPc (Triangle 2 is inside triangle1and does not touch the boundary of triangle 1)Now instead of five cases DR	,PO,EQ,PP,PPc you have eight cases DC,EC, PO, EQ, TPP, NTPP, TPPc, NTPPc");
 
        t7.setFont(new Font(20));
        t7.setFill(Color.BLUE);
        t7.setWrappingWidth(600);
        t7.setTextAlignment(TextAlignment.JUSTIFY);
        
       //
       
        pane.getChildren().addAll(t7);
        pane.setLayoutX(10);pane.setLayoutY(50);
        return pane;
      }
	  
	
	public void start(Stage stage)
    {
       
       // Create buttons and containers
        createButtons();
        authorPane = createFrontPage();
		problemPane = createProblemPage();
		trianglePane = new TextFieldnTriangles();
        rootPane.getChildren().addAll(authorButton,problemButton,triangleButton);
        scene= new Scene(rootPane,700,600,Color.WHITE);
        stage.setScene(scene);
        stage.setTitle("SPATIAL Relations Demo by Kyle Maloney");
        stage.show();
    }
    
    public void removeAllPanes()
    {
        rootPane.getChildren().removeAll(authorPane,problemPane,trianglePane);
    }
    public void createButtons()
    {
        /** create panes */
        authorButton = new Button("Author");
        problemButton = new Button("Problem");
        triangleButton = new Button("TrianglesRelations");

        /** setLayouts */
        authorButton.setLayoutX(100);authorButton.setLayoutY(10);
        problemButton.setLayoutX(180);problemButton.setLayoutY(10);
        triangleButton.setLayoutX(280);triangleButton.setLayoutY(10);
        /** set Controls actions*/
            authorButton.setOnAction(ae->
                                     {removeAllPanes();rootPane.getChildren().add(authorPane);});
            problemButton.setOnAction(ae->
                                     {removeAllPanes();rootPane.getChildren().add(problemPane);});
            triangleButton.setOnAction(ae->
                                  {removeAllPanes();rootPane.getChildren().add(trianglePane);});
	}
    
}    


