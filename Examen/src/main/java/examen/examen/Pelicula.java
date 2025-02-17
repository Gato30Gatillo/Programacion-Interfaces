package examen.examen;

import java.awt.Desktop;
import java.io.File;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.Map;

import javax.swing.JOptionPane;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;

public class Pelicula {
	public static Connection conexion = null;
	String baseDatos = "jdbc:mysql://localhost/empresa";
	String usuario = "root";
	String clave = "toor";

	//Constructor que conecta a la base de datos de prueba
	public Pelicula()
		{
		    try{
		        Class.forName("com.mysql.cj.jdbc.Driver").newInstance();
		        conexion = DriverManager.getConnection(baseDatos,usuario,clave);
		    }
		    catch (ClassNotFoundException cnfe){
		        System.err.println("Fallo al cargar JDBC " + cnfe.getMessage());
		        System.exit(1);
		    }
		    catch (SQLException sqle){
		        System.err.println("No se pudo conectar a BD " + sqle.getMessage());
		        System.exit(1);
		    }
		    catch (java.lang.InstantiationException sqlex){
		        System.err.println("Imposible Conectar");
		        System.exit(1);
		    }
		    catch (Exception ex){
		        System.err.println("Imposible Conectar");
		        System.exit(1);
		    }
		}
		//El método ejecutar recibe el parametro del informe
		public void ejecutar() 
		{
		    //Ruta del informe respecto del proyecto NetBeans
		    String archivojasper="./informes/Examen.jasper";
		    try
		    {
		        //Cargamos los parametros del informe en una tabla Hash
		        Map parametros = new HashMap();
		        //Generamos el informe en memoria
		        JasperPrint print = JasperFillManager.fillReport(archivojasper, parametros, conexion);
		        // Exporta el informe a PDF
		        JasperExportManager.exportReportToPdfFile(print, "informe.pdf");
		        //Abre el archivo PDF generado
		        File path = new File ("informe.pdf");
		        Desktop.getDesktop().open(path);
		    }
		
		    catch(Exception e)
		    {
		        JOptionPane.showMessageDialog(null,e.toString(),"Error",JOptionPane.WARNING_MESSAGE);
		    }
		
		}
	}
