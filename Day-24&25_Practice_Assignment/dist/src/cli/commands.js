"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const TaskManager_1 = require("../services/TaskManager");
const manager = new TaskManager_1.TaskManager();
const args = process.argv.slice(2);
const command = args[0];
switch (command) {
    case "create-user":
        manager.createUser({
            id: Date.now(),
            name: args[1],
            email: args[2]
        });
        break;
    case "create-task":
        manager.createTask({
            id: Date.now(),
            title: args[1],
            status: "Pending"
        });
        break;
    case "assign-task":
        manager.assignTask(Number(args[1]), Number(args[2]));
        break;
    case "list-tasks":
        console.log(manager.getTasks());
        break;
    case "complete-task":
        manager.completeTask(Number(args[1]));
        break;
    default:
        console.log("Invalid command");
}
