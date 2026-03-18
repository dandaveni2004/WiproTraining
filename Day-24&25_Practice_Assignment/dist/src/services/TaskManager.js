"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.TaskManager = void 0;
class TaskManager {
    constructor() {
        this.users = [
            { id: 1, name: "Rahul", email: "rahul@email.com" }
        ];
        this.tasks = [
            { id: 1, title: "Build API", status: "Pending", assignedUserId: undefined }
        ];
    }
    createUser(user) {
        this.users.push(user);
        console.log(`User created: ${user.name}`);
    }
    createTask(task) {
        this.tasks.push(task);
        console.log(`Task created: ${task.title}`);
    }
    assignTask(taskId, userId) {
        const task = this.tasks.find(t => t.id === taskId);
        const user = this.users.find(u => u.id === userId);
        if (task && user) {
            task.assignedUserId = userId;
            console.log(`Task assigned to ${user.name}`);
        }
        else {
            console.log("Task or user not found");
        }
    }
    completeTask(taskId) {
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
exports.TaskManager = TaskManager;
