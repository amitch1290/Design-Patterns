package com.techprimers.designpatterns.composite;

public class CompositeExample {

    public static void main(String[] args) {

        Employee developer1 = new Developer("Peter", 1, 100L);
        Employee developer2 = new Developer("Sam", 2, 200L);
        Employee developer3 = new Developer("Ryan", 3, 200L);
        Employee developer4 = new Developer("Ryan V", 6, 200L);
        Employee developer5 = new Developer("Ryan X", 7, 200L);
        Employee lead1 = new Lead("Mike", 4, 2000L);
        Employee lead2 = new Lead("Chris", 5, 2000L);
        Employee manager = new Manager("Will", 8, 50000L);



        lead1.add(developer1);
        lead1.add(developer2);
        lead1.add(developer3);

        System.out.println(lead1.toString());
        lead2.add(developer4);
        System.out.println(lead2.toString());

        manager.add(lead1);
        manager.add(lead2);
        manager.add(developer5);


        System.out.println(manager.toString());


    }
}

public class Developer extends Employee {
    public Developer(String name, Integer empId, Long salary) {
        super(name, empId, salary);
    }

    @Override
    public String toString() {

        StringBuilder builder = new StringBuilder("Developer: ");
        builder.append(name);
        builder.append(",");
        builder.append(empId);

        return builder.toString();
    }
}

public abstract class Employee {
    protected String name;
    protected Integer empId;
    protected Long salary;

    public Employee(String name, Integer empId, Long salary) {
        this.name = name;
        this.empId = empId;
        this.salary = salary;
    }

    public void add(Employee employee) {
        throw new UnsupportedOperationException("Cannot add reportee by default");
    }

    public void remove(Employee employee) {
        throw new UnsupportedOperationException("Cannot add reportee by default");
    }

    public abstract String toString();

}

import java.util.ArrayList;
import java.util.List;

public class Lead extends Employee {

    private List<Employee> employees = new ArrayList<>();

    public Lead(String name, Integer empId, Long salary) {
        super(name, empId, salary);
    }


    @Override
    public void add(Employee employee){
        employees.add(employee);
    }

    @Override
    public void remove(Employee employee){
        employees.remove(employee);
    }

    @Override
    public String toString() {

        StringBuilder builder = new StringBuilder("Lead: ");
        builder.append(name);
        builder.append(",");
        builder.append(empId);
        builder.append("... ");

        builder.append("Employees:");

        employees
                .forEach(employee -> builder.append(employee.toString()));

        return builder.toString();
    }
}
 

import java.util.ArrayList;
import java.util.List;

public class Manager extends Employee {

    private List<Employee> employees = new ArrayList<>();

    public Manager(String name, Integer empId, Long salary) {
        super(name, empId, salary);
    }

    @Override
    public void add(Employee employee){
        employees.add(employee);
    }

    @Override
    public void remove(Employee employee){
        employees.remove(employee);
    }

    @Override
    public String toString() {

        StringBuilder builder = new StringBuilder("Manager: ");
        builder.append(name);
        builder.append(",");
        builder.append(empId);
        builder.append("... ");
        builder.append("Employees:");

        employees
                .forEach(employee -> builder.append(employee.toString()));
        return builder.toString();
    }
}