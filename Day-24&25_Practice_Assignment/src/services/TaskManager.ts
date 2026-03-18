import { IUser } from "../models/IUser";
import { ITask } from "../models/ITask";

export class TaskManager {

  private users: IUser[] = [
    { id: 1, name: "Rahul", email: "rahul@email.com" }
  ];

  private tasks: ITask[] = [
    { id: 1, title: "Build API", status: "Pending", assignedUserId: undefined }
  ];

  createUser(user: IUser) {
    this.users.push(user);
    console.log(`User created: ${user.name}`);
  }

  createTask(task: ITask) {
    this.tasks.push(task);
    console.log(`Task created: ${task.title}`);
  }

  assignTask(taskId: number, userId: number) {

    const task = this.tasks.find(t => t.id === taskId);
    const user = this.users.find(u => u.id === userId);

    if (task && user) {
      task.assignedUserId = userId;
      console.log(`Task assigned to ${user.name}`);
    } else {
      console.log("Task or user not found");
    }

  }

  completeTask(taskId: number) {

    const task = this.tasks.find(t => t.id === taskId);

    if (task) {
      task.status = "Completed";
      console.log("Task marked as completed");
    }

  }

  getTasks() {
    return this.tasks;
  }

}