/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

/**
 * 
 * @export
 * @enum {string}
 */
export enum NodeType {
    Container = 2,
    Site = 100,
    Web = 200,
    List = 300,
    DocumentLibrary = 310,
    Folder = 400,
    Item = 500,
    File = 501,
    None = -2
}

export function NodeTypeFromJSON(json: any): NodeType {
    return NodeTypeFromJSONTyped(json, false);
}

export function NodeTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): NodeType {
    return json as NodeType;
}

export function NodeTypeToJSON(value?: NodeType | null): any {
    return value as any;
}

