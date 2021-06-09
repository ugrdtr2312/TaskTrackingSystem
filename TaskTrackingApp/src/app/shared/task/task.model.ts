export class Task {
    id: number = 0
    name: string = ''
    description: string = ''
    creationDate: string = ''
    lastUpdate: string = ''
    deadline: string = ''
    taskStatus: string = ''
    taskStatusId: number = 1
    taskPriority: string = ''
    taskPriorityId: number = 1
    projectId: number = 0
    userId?: number = 0
}
