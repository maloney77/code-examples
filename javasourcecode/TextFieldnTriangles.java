/*Demo of text fields, a label   and drawing of triangles
 Create two triangles for manipulation one for drawing
*/
package code;
/*
 import library packages
 */


import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.text.Text;
import javafx.scene.shape.Polygon;
import javafx.scene.layout.VBox;
import javafx.scene.layout.HBox;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.application.Application;
//actions items
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.input.MouseEvent;
//Label text alignment
import javafx.scene.text.TextAlignment;
//paint and othe useful classes
import javafx.scene.paint.Color;
import java.util.Scanner;
import static java.lang.Math.*;
import javafx.geometry.Pos;
import javafx.beans.property.Property;
//Shape
import javafx.scene.shape.Path;
import javafx.scene.shape.LineTo;
import javafx.scene.shape.MoveTo;


/**
 *
 * @author Kyle Maloney
 */

public class TextFieldnTriangles extends Pane {
    /** create triangles with default values*/
    Polygon triangle1 = new Polygon();
    Polygon triangle2 = new Polygon();
    //triangle1.getPoints().addAll(new Double[]{50, 0, 0, 100, 100, 100});
    //triangle2.getPoints().addAll(new Double[]{200, 0, 150, 100, 250, 100});
    /** create layouts*/
    Pane pane = new Pane();
    GridPane gridPane = new GridPane();
    HBox hBox = new HBox();
    VBox root = new VBox();
    
	
	
    public TextFieldnTriangles() {
        
        /** Create textfield and labels */
        createTextField();
		
       /** Pane  holds two triangles*/
        //pane.getChildren().addAll(triangle1, triangle2);
                /**VBox to hold all component*/
        
        /**add all componrnts to the root*/
		
      

        this.getChildren().addAll(label1,label3,tField,label4,hBox,label7, pane, label5, label6, label8);
        
        
    }
    


    
    
    public double distanceCalc(double d1, double s1, double d2, double s2)
	{
	   double d =sqrt((d2-d1)*(d2-d1) + (s2-s1)*(s2-s1));
	   return d;
	}
    /** declare Label and Text variables */
    Label label1,label3,label7, label2, label4,label5,label6, label8;
    TextField tField;
    double x1,y1,x2,y2,x3,y3;
    double x4,y4,x5,y5,x6,y6;

    /** Create LabelsTextField */
    public void createTextField ()
    {
		setOnMouseClicked(me->{
			Polygon triangle1 = new Polygon();
			if(me.getClickCount() ==1)
			{
				label7.setText(me.getX() + ", " + me.getY());
				x1 = me.getX();
				y1 = me.getY();
			}
			else if(me.getClickCount() == 2)
			{
				label7.setText((me.getX() +100) + ", " + (me.getY() +100));
				x2 = me.getX();
				y2 = me.getY();
			}
			else
			{
				
				x3 = me.getX();
				y3 = me.getY();
			}
			TextFieldnTriangles.this.getChildren().remove(pane); 
              pane = new Pane();
              triangle1.getPoints().addAll(new Double[]{x1, y1, x2, y2, x3, y3});
			  triangle1.setStroke(Color.BLACK);
			  triangle1.setFill(Color.RED);
			  pane.getChildren().addAll(triangle1);
			  TextFieldnTriangles.this.getChildren().add(pane);
			  pane.setLayoutX(50);         pane.setLayoutY(400);
		});
		
        label1 = new Label();
        label1.setText("     Spatial Relations with Triangles Demo\n\n");
        label1.setTextAlignment(TextAlignment.CENTER);
        label1.setTextFill(Color.BLUE);
       
        label3 = new Label();
        label3.setText("     Input Triangles Data: x1 y1 x2 y2 x3 y3 every 6 numbers is ONE triangle \n\n");
        label3.setTextAlignment(TextAlignment.CENTER);
        label3.setTextFill(Color.BLUE);
        
        label4 = new Label();
        label4.setText(" ");
        label4.setTextAlignment(TextAlignment.CENTER);
        label4.setTextFill(Color.GREEN);
  
        
        tField = new TextField("50 0 0 100 100 100 200 0 150 100 250 100");
        tField.setOnAction(new TextFieldHandler());

        label5 = new Label();
        label5.setText("\n\tTriangle 1 is RED ");
        label5.setTextAlignment(TextAlignment.CENTER);
        label5.setTextFill(Color.RED);
        
        label6 = new Label();
        label6.setText("\n\tTriangle 2 is BLUE ");
        label6.setTextAlignment(TextAlignment.CENTER);
        label6.setTextFill(Color.BLUE);
        
        //hBox.getChildren().addAll(label5,label6);
        
        label7 = new Label();
        label7.setText("      The output is: the triangles OVERLAP");
        label7.setTextAlignment(TextAlignment.CENTER);
        label7.setTextFill(Color.MAGENTA);
		
		label8 = new Label();
		label8.setTextAlignment(TextAlignment.CENTER);
		
		
        label1.setLayoutX(10);      label1.setLayoutY(90);
        label3.setLayoutX(10);      label3.setLayoutY(110);
        tField.setLayoutX(25);      tField.setLayoutY(160);
		label8.setLayoutX(25);		label8.setLayoutY(190);
        label4.setLayoutX(10);      label4.setLayoutY(200);
        label5.setLayoutX(10);      label5.setLayoutY(250);
        label6.setLayoutX(120);      label6.setLayoutY(250);
		label7.setLayoutX(10);		label7.setLayoutY(300);
		pane.setLayoutX(10);         pane.setLayoutY(400);
        
		
		setOnMouseMoved(me->{
			double x=me.getX(),y=me.getY();               
			           
			label8.setText("Mouse is at ("+x+","+y+")");
		});
		
    }

    
    Scanner scanner;
    
  
    public String analyse(String str)
    {
		  x1 = 50;
          x1 = scanner.nextInt();
		  y1 = 0;
          y1 = scanner.nextInt();
		  x2 = 0;
          x2 = scanner.nextInt();
		  y2 = 100;
          y2 = scanner.nextInt();
		  x3 = 100;
          x3 = scanner.nextInt();
		  y3 = 100;
          y3 = scanner.nextInt();
		  
		  x4 = 200;
          x4 = scanner.nextInt();
		  y4 = 0;
          y4 = scanner.nextInt();
		  x5 = 150;
          x5 = scanner.nextInt();
		  y5 = 100;
          y5 = scanner.nextInt();
		  x6 = 250;
          x6 = scanner.nextInt();
		  y6 = 100;
          y6 = scanner.nextInt();
		  
		  
		 
	      triangle1.getPoints().addAll(new Double[]{x1, y1, x2, y2, x3, y3});
	      triangle2.getPoints().addAll(new Double[]{x4, y4, x5, y5, x6, y6});
	
	
	double distance1, distance2, distance3, distance4, distance5, distance6, distance7, distance8, distance9;
	distance1 = distanceCalc(x1, y1, x5, y5);
	distance2 = distanceCalc(x3, y3, x5, y5);
	distance3 = distanceCalc(x1, y1, x3, y3);

	distance4 = distanceCalc(x2, y2, x4, y4);
	distance5 = distanceCalc(x3, y3, x4, y4);
	distance6 = distanceCalc(x2, y2, x3, y3);
	
	distance7 = distanceCalc(x1, y1, x6, y6);
	distance8 = distanceCalc(x2, y2, x6, y6);
	distance9 = distanceCalc(x1, y1, x2, y2);

	//identical
	  if ((x1==x4) & (y1==y4) & (x2==x5) & (y2==y5) & (x3==x6) & (y3==y6))
            return "    The two triangles are equal, identical.";
	else if((x2 <= x6 & x2 >= x5) & (x3 <= x6 & x3 >= x5) & (y2 == y5) & (y3 == y6))
	    return "  Triangle 1 is TTP of triangle 2";
	//TTPc
	  else if((x5 <= x3 & x5 >= x2) & (x6 <= x3 & x6 >= x2) & (y2 == y5) & (y3 == y6))
	    return "  Triangle 2 is TTPc of triangle 1";
	//TTP
	  
	//NTTPc
	  else if(triangle1.contains(x4, y4) & triangle1.contains(x5, y5) & triangle1.contains(x6, y6))
	    return "     Triangle 2 is NTPPc of triangle 1";
	//proper overlap
	  else if(triangle1.contains(x4, y4) || triangle1.contains(x5, y5) || triangle1.contains(x6, y6))
            return "    The triangles are proper overlap";
	//NTTP
	else if(triangle2.contains(x1, y1) & triangle2.contains(x2, y2) & triangle2.contains(x3, y3))
	    return "     Triangle 1 is NTPP of triangle 2";
	//externally connected
	  else if((distance1 + distance2) == distance3 || (distance4 + distance5) == distance6 || (distance7 + distance8) == distance9)
	      return "    The triangles are externally connected.";
      else
	 //DC
          return "    The two triangles are disconnected";
	   
	
	
  }
     


    public class TextFieldHandler implements EventHandler<ActionEvent>{
        public void handle( ActionEvent e)
        {
			Polygon triangle1 = new Polygon();
            Polygon triangle2 = new Polygon();
            String str = tField.getText();
            label4.setText("\n    Input is: "+str);
            scanner = new Scanner(str);
            str = analyse(str);
            //tField.setText( "" );  // clear data entry field
            label7.setText(str);
            TextFieldnTriangles.this.getChildren().remove(pane); 
              pane = new Pane();
              triangle1.getPoints().addAll(new Double[]{x1, y1, x2, y2, x3, y3});
			  triangle2.getPoints().addAll(new Double[]{x4, y4, x5, y5, x6, y6});
              triangle1.setStroke(Color.BLACK);
			  triangle1.setFill(Color.RED);
			  triangle2.setStroke(Color.RED);
			  triangle2.setFill(Color.BLUE);
              pane.getChildren().addAll(triangle1,triangle2);
            TextFieldnTriangles.this.getChildren().add(pane);
			pane.setLayoutX(50);         pane.setLayoutY(400);
	    
	    
        }
    }
    
}
